using AccountApi.Models;
using AccountApi.Pagination;

namespace AccountApi.Interfaces;

public interface IOwnerRepository
{
    Task<IEnumerable<Owner>> GetOwnersAsync();
    Task<Owner> GetOwnerByIdAsync(Guid id);
    Task<Owner> GetOwnerWithDetailsAsync(Guid id);
    void InsertOwner(Owner owner);
    void UpdateOwner(Owner owner);
    void DeleteOwner(Owner owner);

    Task<PagedList<Owner>> GetOwnersWithPaginationAsync(OwnersParameters ownersParameters);
    Task<PagedList<Owner>> GetOwnersWithFilteringAsync(OwnersParameters ownersParameters);
}
