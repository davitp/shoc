import { auth, getJwt } from "@/addons/auth"
import AppHeader from "@/components/layout/app-header";
import { Button } from "@/components/ui/button";
import WorkspaceSidebar from "@/components/workspace/workspace-sidebar";

export default async function Home() {

  const session = await auth();

  return <div className="grid min-h-screen w-full">

    <div className="flex flex-col w-full">
      <AppHeader />
      <main className="flex h-full">
        <WorkspaceSidebar />
        <div className="flex flex-1 flex-col gap-4 p-4 lg:gap-6 lg:p-6">
          <div className="flex items-center">
            <h1 className="text-lg font-semibold md:text-2xl">Inventory</h1>
          </div>
          <div
            className="flex flex-1 items-center justify-center rounded-lg border border-dashed shadow-sm"
            x-chunk="dashboard-02-chunk-1"
          >
            <div className="flex flex-col items-center gap-1 text-center">
              <h3 className="text-2xl font-bold tracking-tight">You have no products</h3>
              <p className="text-sm text-muted-foreground">You can start selling as soon as you add a product.</p>
              <Button className="mt-4">Add Product</Button>
            </div>
          </div>
        </div>
      </main>
    </div>
  </div>
}
