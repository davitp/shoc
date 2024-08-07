"use client"

import { Badge } from "@/components/ui/badge";
import { Button } from "@/components/ui/button";
import { Card, CardDescription, CardFooter, CardHeader, CardTitle } from "@/components/ui/card";
import { useIntl } from "react-intl";
import UsersIcon from "@/components/icons/users-icon";
import OrganizationIcon from "@/components/icons/organization-icon";
import KeyIcon from "@/components/icons/key-icon";
import { useState } from "react";
import { Check, X } from "lucide-react";
import { workspaceRolesMap, workspaceTypesMap } from "../../_components/well-known";
import InvitationDeclineDialog from "./invitation-decline-dialog";
import InvitationAcceptDialog from "./invitation-accept-dialog";

export default function InvitationCard({ invitation, onAccepted = () => {}, onDeclined = () => {} }: any) {
    
    const [acceptActive, setAcceptActive] = useState(false);
    const [declineActive, setDeclineActive] = useState(false);
    const intl = useIntl();

    return <Card className="w-full">
        <InvitationAcceptDialog 
            item={invitation}
            open={acceptActive}
            onClose={() => setAcceptActive(false)}
            onSuccess={result => onAccepted(result)}
        />
        <InvitationDeclineDialog 
            item={invitation}
            open={declineActive}
            onClose={() => setDeclineActive(false)}
            onSuccess={result => onDeclined(result)}
        />
        
        <div className="flex">
            <div className="flex-1">
                <CardHeader>
                    <CardTitle className="truncate leading-normal">{invitation.workspaceName}</CardTitle>
                    <CardDescription className="text-balance">{invitation.workspaceDescription}</CardDescription>
                </CardHeader>

                <CardFooter>
                    <Badge variant="secondary">
                        {invitation.workspaceType === 'individual' && <UsersIcon className="w-4 h-4 mr-1" />}
                        {invitation.workspaceType === 'organization' && <OrganizationIcon className="w-4 h-4 mr-1" />}
                        {intl.formatMessage({ id: 'workspaces.labels.type' })}: {intl.formatMessage({ id: workspaceTypesMap[invitation.workspaceType] })}
                    </Badge>
                    <Badge variant="secondary" className="ml-2">
                        <KeyIcon className="w-4 h-4 mr-1" />
                        {intl.formatMessage({ id: 'workspaces.labels.role' })}: {intl.formatMessage({ id: workspaceRolesMap[invitation.role] })}
                    </Badge>
                </CardFooter>
            </div>
            <div className="flex p-6">
                <div className="flex m-auto p-0 space-x-1">
                    <Button key="accept" variant="outline" onClick={() => setAcceptActive(true)}>
                        {intl.formatMessage({ id: 'global.actions.accept' })} <Check className="w-4 h-4 ml-2" />
                    </Button>
                    <Button key="decline" variant="destructive" onClick={() => setDeclineActive(true)}>
                        {intl.formatMessage({ id: 'global.actions.decline' })} <X className="w-4 h-4 ml-2" />
                    </Button>
                </div>
            </div>
        </div>
    </Card>
}