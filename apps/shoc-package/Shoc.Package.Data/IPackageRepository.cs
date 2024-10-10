using System.Collections.Generic;
using System.Threading.Tasks;
using Shoc.Package.Model.Package;

namespace Shoc.Package.Data;

/// <summary>
/// The repository interface
/// </summary>
public interface IPackageRepository
{
    /// <summary>
    /// Gets all the objects
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<PackageModel>> GetAll(string workspaceId);
    
    /// <summary>
    /// Gets the object by id
    /// </summary>
    /// <returns></returns>
    Task<PackageModel> GetById(string workspaceId, string id);

    /// <summary>
    /// Creates the object with given input
    /// </summary>
    /// <param name="workspaceId">The workspace id</param>
    /// <param name="input">The creation input</param>
    /// <returns></returns>
    Task<PackageModel> Create(string workspaceId, PackageCreateModel input);
    
    /// <summary>
    /// Deletes the object by id
    /// </summary>
    /// <param name="workspaceId">The workspace id</param>
    /// <param name="id">The id of the object</param>
    /// <returns></returns>
    Task<PackageModel> DeleteById(string workspaceId, string id);
}