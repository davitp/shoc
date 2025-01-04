namespace Shoc.Job.Model;

/// <summary>
/// The job errors
/// </summary>
public static class JobErrors
{   
    /// <summary>
    /// The workspace is invalid
    /// </summary>
    public const string INVALID_WORKSPACE = "JOB_INVALID_WORKSPACE";
    
    /// <summary>
    /// The user is invalid
    /// </summary>
    public const string INVALID_USER = "JOB_INVALID_USER";
    
    /// <summary>
    /// The package is invalid
    /// </summary>
    public const string INVALID_PACKAGE = "JOB_INVALID_PACKAGE";

    /// <summary>
    /// The cluster is invalid
    /// </summary>
    public const string INVALID_CLUSTER = "JOB_INVALID_CLUSTER";

    /// <summary>
    /// The secrets are invalid
    /// </summary>
    public const string INVALID_SECRETS = "JOB_INVALID_SECRETS";
    
    /// <summary>
    /// The package runtime is invalid
    /// </summary>
    public const string INVALID_PACKAGE_RUNTIME = "JOB_INVALID_PACKAGE_RUNTIME";

    /// <summary>
    /// The invalid runtime type
    /// </summary>
    public const string INVALID_RUNTIME_TYPE = "JOB_INVALID_RUNTIME_TYPE";

    /// <summary>
    /// The registry is invalid
    /// </summary>
    public const string INVALID_REGISTRY = "JOB_INVALID_REGISTRY";

    /// <summary>
    /// The registry credentials are invalid
    /// </summary>
    public const string INVALID_REGISTRY_CREDENTIALS = "JOB_INVALID_REGISTRY_CREDENTIALS";
    
    /// <summary>
    /// The label name is invalid
    /// </summary>
    public const string INVALID_LABEL_NAME = "JOB_INVALID_LABEL_NAME";
    
    /// <summary>
    /// The label name exists
    /// </summary>
    public const string EXISTING_LABEL_NAME = "JOB_EXISTING_LABEL_NAME";

    /// <summary>
    /// The scope is invalid
    /// </summary>
    public const string INVALID_JOB_SCOPE = "JOB_INVALID_JOB_SCOPE";
    
    /// <summary>
    /// The job manifest is invalid or missing
    /// </summary>
    public const string INVALID_JOB_MANIFEST = "JOB_INVALID_JOB_MANIFEST";

    /// <summary>
    /// Too many labels referenced
    /// </summary>
    public const string INVALID_JOB_LABELS_LIMIT = "JOB_INVALID_JOB_LABELS_LIMIT";

    /// <summary>
    /// The invalid job label referenced
    /// </summary>
    public const string INVALID_JOB_LABEL_REFERENCE = "JOB_INVALID_JOB_LABEL_REFERENCE";

    /// <summary>
    /// The invalid git repo referenced
    /// </summary>
    public const string INVALID_JOB_GIT_REPO = "JOB_INVALID_JOB_GIT_REPO";

    /// <summary>
    /// The job arguments are invalid
    /// </summary>
    public const string INVALID_JOB_ARGUMENTS = "JOB_INVALID_JOB_ARGUMENTS";

    /// <summary>
    /// The invalid job array
    /// </summary>
    public const string INVALID_JOB_ARRAY = "JOB_INVALID_JOB_ARRAY";
    
    /// <summary>
    /// The invalid job resources
    /// </summary>
    public const string INVALID_JOB_RESOURCES = "JOB_INVALID_JOB_RESOURCES";
    
    /// <summary>
    /// The invalid job environment
    /// </summary>
    public const string INVALID_JOB_ENVIRONMENT = "JOB_INVALID_JOB_ENVIRONMENT";
    
    /// <summary>
    /// The unknown error
    /// </summary>
    public const string UNKNOWN_ERROR = "JOB_UNKNOWN_ERROR";
}
