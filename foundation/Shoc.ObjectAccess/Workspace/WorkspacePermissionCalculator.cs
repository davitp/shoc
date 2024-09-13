using System.Collections.Generic;
using Shoc.ObjectAccess.Model.Workspace;

namespace Shoc.ObjectAccess.Workspace;

/// <summary>
/// Workspace permission calculator
/// </summary>
public class WorkspacePermissionCalculator
{
    /// <summary>
    /// The static mappings between workspace roles and permissions
    /// </summary>
    private static readonly IDictionary<string, ISet<string>> ROLE_PERMISSIONS = new Dictionary<string, ISet<string>>
    {
        {
            WorkspaceRoles.OWNER,
            WorkspacePermissions.ALL
        },
        {
            WorkspaceRoles.ADMIN,
            new HashSet<string>
            {
                WorkspacePermissions.WORKSPACE_VIEW,
                WorkspacePermissions.WORKSPACE_EDIT,
                WorkspacePermissions.WORKSPACE_DELETE,
                WorkspacePermissions.WORKSPACE_LIST_MEMBERS,
                WorkspacePermissions.WORKSPACE_UPDATE_MEMBER,
                WorkspacePermissions.WORKSPACE_DELETE_MEMBER,
                WorkspacePermissions.WORKSPACE_LIST_INVITATIONS,
                WorkspacePermissions.WORKSPACE_CREATE_INVITATION,
                WorkspacePermissions.WORKSPACE_UPDATE_INVITATION,
                WorkspacePermissions.WORKSPACE_DELETE_INVITATION,
                WorkspacePermissions.WORKSPACE_LIST_CLUSTERS
            }
        },
        {
            WorkspaceRoles.MEMBER,
            new HashSet<string>
            {
                WorkspacePermissions.WORKSPACE_VIEW,
                WorkspacePermissions.WORKSPACE_LIST_MEMBERS,
                WorkspacePermissions.WORKSPACE_LIST_CLUSTERS
            }
        },
        {
            WorkspaceRoles.GUEST,
            new HashSet<string>
            {
                WorkspacePermissions.WORKSPACE_VIEW
            }
        }
    };
        
    /// <summary>
    /// Gets the permissions assigned to the role
    /// </summary>
    /// <param name="roles">The roles</param>
    /// <returns></returns>
    public virtual ISet<string> Calculate(params string[] roles)
    {
        // resulting set of permissions
        var result = new HashSet<string>();

        // do for every role
        foreach (var role in roles)
        {
            // no such role
            if (!ROLE_PERMISSIONS.TryGetValue(role, out var assigned))
            {
                continue;
            }
            
            // add role permissions
            result.UnionWith(assigned);
        }
        
        // return resulting set
        return result;
    }
}