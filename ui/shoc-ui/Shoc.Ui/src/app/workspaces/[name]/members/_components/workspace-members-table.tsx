"use client"

import DataTable from "@/components/data-table"
import WorkspaceMemberDeleteDialog from "./workspace-member-delete-dialog"
import { type ColumnDef } from "@tanstack/react-table"
import { Badge } from "@/components/ui/badge"
import { WorkspaceMember } from "./types"
import DataTableColumnHeader from "@/components/data-table/data-table-column-header"
import { useIntl } from "react-intl"
import KeyIcon from "@/components/icons/key-icon"
import { workspaceRolesMap } from "@/app/workspaces/(chooser)/_components/well-known"
import { localDate } from "@/extended/format"
import { MoreHorizontal } from "lucide-react"
import { Button } from "@/components/ui/button"
import { DropdownMenu, DropdownMenuContent, DropdownMenuItem, DropdownMenuLabel, DropdownMenuSeparator, DropdownMenuTrigger } from "@/components/ui/dropdown-menu"
import { rpc } from "@/server-actions/rpc"
import WorkspaceMemberUpdateDialog from "./workspace-member-update-dialog"
import { useCallback, useEffect, useMemo, useState } from "react"
import useWorkspaceAccess from "@/providers/workspace-access/use-workspace-access"

export default function WorkspaceMembersTable({ workspaceId, className }: { workspaceId: string, className?: string }) {

  const intl = useIntl();
  const { hasAny } = useWorkspaceAccess();
  const [progress, setProgress] = useState(true);
  const [data, setData] = useState<any[]>([]);
  const [errors, setErrors] = useState<any[]>([]);
  const [editingItem, setEditingItem] = useState<any>(null);

  const load = useCallback(async (workspaceId: string) => {

    setProgress(true);
    const { data, errors } = await rpc('workspace/user-workspace-members/getAll', { workspaceId })

    if (errors) {
      setErrors(errors);
      setData([]);
    } else {
      setErrors([]);
      setData(data)
    }

    setProgress(false);

  }, []);


  useEffect(() => {
    if (!workspaceId) {
      return;
    }
    load(workspaceId);
  }, [workspaceId, load])

  const columns: ColumnDef<WorkspaceMember>[] = useMemo(() => [
    {
      accessorKey: "fullName",
      header: ({ column }) => (
        <DataTableColumnHeader column={column} title={intl.formatMessage({ id: 'global.labels.name' })} />
      ),
      cell: ({ row }) => <div>{row.getValue("fullName")}</div>,
      enableSorting: true,
      enableHiding: false,
      size: 100
    },
    {
      accessorKey: "email",
      header: ({ column }) => (
        <DataTableColumnHeader column={column} title={intl.formatMessage({ id: 'global.labels.email' })} />
      ),
      cell: ({ row }) => <div>{row.getValue("email")}</div>,
      enableSorting: true,
      enableHiding: false,
    },
    {
      accessorKey: "role",
      header: ({ column }) => (
        <DataTableColumnHeader column={column} title={intl.formatMessage({ id: 'workspaces.labels.role' })} />
      ),
      cell: ({ row }) => <Badge variant="secondary">
        <KeyIcon className="w-4 h-4 mr-1" />
        {intl.formatMessage({ id: 'workspaces.labels.role' })}: {intl.formatMessage({ id: workspaceRolesMap[row.getValue('role') as string] })}
      </Badge>,
      enableSorting: true,
      enableHiding: false,
    },
    {
      accessorKey: "created",
      header: ({ column }) => (
        <DataTableColumnHeader column={column} title={intl.formatMessage({ id: 'workspaces.members.labels.since' })} />
      ),
      cell: ({ row }) => localDate(row.getValue('created')),
      enableSorting: true,
      enableHiding: false,
    },
    {
      id: "actions",
      enableHiding: false,
      enableSorting: false,
      header: ({ column }) => (
        <DataTableColumnHeader column={column} title={intl.formatMessage({ id: 'global.labels.actions' })} />
      ),
      cell: function Cell({ row }) {
        const [deleteOpen, setDeleteOpen] = useState(false);

        return (<>
          <WorkspaceMemberDeleteDialog
            open={deleteOpen}
            onClose={() => setDeleteOpen(false)}
            item={row.original}
            onSuccess={() => {
              load(workspaceId)
            }}
          />
          <DropdownMenu>
            <DropdownMenuTrigger asChild>
              <Button variant="ghost" className="h-8 w-8 p-0">
                <MoreHorizontal className="h-4 w-4" />
              </Button>
            </DropdownMenuTrigger>
            <DropdownMenuContent align="end">
              <DropdownMenuLabel>{intl.formatMessage({ id: 'global.labels.actions' })}</DropdownMenuLabel>
              <DropdownMenuItem
                onClick={() => setEditingItem(row.original)}
                disabled={row.original.role === 'owner' || !hasAny(['workspace_update_member'])}
              >
                {intl.formatMessage({ 'id': 'global.actions.update' })}
              </DropdownMenuItem>
              <DropdownMenuItem
                className="text-red-600 hover:!text-red-600 hover:!bg-red-100"
                onClick={() => setDeleteOpen(true)}
                disabled={row.original.role === 'owner' || !hasAny(['workspace_delete_member'])}
              >
                {intl.formatMessage({ 'id': 'global.actions.delete' })}
              </DropdownMenuItem>
            </DropdownMenuContent>
          </DropdownMenu>
        </>
        )
      }
    }
  ], [intl, load, workspaceId])

  return (
    <>
      <WorkspaceMemberUpdateDialog
        workspaceId={workspaceId}
        item={editingItem}
        open={editingItem}
        onClose={() => setEditingItem(null)} onSuccess={() => {
          load(workspaceId)
        }} />
      <DataTable
        className={className}
        data={data}
        columns={columns}
        progress={progress}
        errors={errors}
      >
      </DataTable>
    </>
  )
}