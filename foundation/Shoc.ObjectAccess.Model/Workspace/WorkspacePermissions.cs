using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Shoc.ObjectAccess.Model.Workspace;

/// <summary>
/// The known workspace permissions
/// </summary>
public class WorkspacePermissions
{
    /// <summary>
    /// See the list of workspaces
    /// </summary>
    public const string WORKSPACES_LIST = "workspaces_list";

    /// <summary>
    /// View the workspace
    /// </summary>
    public const string WORKSPACE_VIEW = "workspace_view";
    
    /// <summary>
    /// Update the workspace
    /// </summary>
    public const string WORKSPACE_UPDATE = "workspace_update";

    /// <summary>
    /// Delete the workspace
    /// </summary>
    public const string WORKSPACE_DELETE = "workspace_delete";
    
    /// <summary>
    /// Get and initialize all the constants
    /// </summary>
    public static readonly ISet<string> ALL = GetAll();

    /// <summary>
    /// Gets all the constant values
    /// </summary>
    /// <returns></returns>
    private static ISet<string> GetAll()
    {
        return typeof(WorkspacePermissions)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => !f.IsInitOnly && f.IsLiteral && f.FieldType == typeof(string))
            .Select(f => f.GetRawConstantValue() as string)
            .ToHashSet();
    }
}