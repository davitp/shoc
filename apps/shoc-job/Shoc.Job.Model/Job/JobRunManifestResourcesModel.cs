namespace Shoc.Job.Model.Job;

/// <summary>
/// The job run manifest resources model
/// </summary>
public class JobRunManifestResourcesModel
{
    /// <summary>
    /// The number of CPU units to allocate
    /// </summary>
    public string Cpu { get; set; }
    
    /// <summary>
    /// The amount of memory to allocate
    /// </summary>
    public string Memory { get; set; }
    
    /// <summary>
    /// The amount of NVIDIA GPU units to allocate
    /// </summary>
    public string NvidiaGpu { get; set; }
    
    /// <summary>
    /// The amount of AMD GPU units to allocate
    /// </summary>
    public string AmdGpu { get; set; }
}