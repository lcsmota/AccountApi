using AccountApi.Models;

namespace AccountApi.Interfaces;

public interface IOwnerRepository
{
    Task<IEnumerable<Owner>> GetOwnersAsync();
    Task<Owner> GetOwnerByIdAsync(Guid id);
    Task<Owner> GetOwnerWithDetailsAsync(Guid id);
    void InsertOwner(Owner owner);
    void UpdateOwner(Owner owner);
    void DeleteOwner(Owner owner);
}
