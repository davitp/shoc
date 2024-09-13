namespace Shoc.Cluster.Model.Cluster;

/// <summary>
/// The cluster configuration update model
/// </summary>
public class ClusterConfigurationUpdateModel
{
    /// <summary>
    /// The id of the cluster in the system
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// The workspace associated with the cluster
    /// </summary>
    public string WorkspaceId { get; set; }
    
    /// <summary>
    /// The configuration including authentication, endpoints, etc.
    /// </summary>
    public string Configuration { get; set; }
}