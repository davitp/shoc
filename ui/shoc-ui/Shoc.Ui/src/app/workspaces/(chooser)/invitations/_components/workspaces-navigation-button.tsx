"use client"

import { Button } from "@/components/ui/button";
import { ArrowLeftIcon } from "lucide-react";
import { useRouter } from "next/navigation";
import { useIntl } from "react-intl";

export default function WorkspacesNavigationButton({ className }: { className?: string }) {
    const intl = useIntl();
    const router = useRouter();
    return <Button variant="outline" className={className} onClick={() => router.push('/workspaces')}>
        <ArrowLeftIcon className="w-4 h-4 mr-2" />
        {intl.formatMessage({ id: 'workspaces' })}
    </Button>
}