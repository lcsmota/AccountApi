using AccountApi.Context;
using AccountApi.Interfaces;
using AccountApi.Models;
using AccountApi.Pagination;
using Microsoft.EntityFrameworkCore;

namespace AccountApi.Repository;

public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
{
    public OwnerRepository(AppDbContext context)
        : base(context) { }

    public async Task<IEnumerable<Owner>> GetOwnersAsync()
        =>
            await GetAll()
            .OrderBy(ow => ow.Name)
            .ToListAsync();

    public async Task<Owner> GetOwnerByIdAsync(Guid id)
        =>
            await GetByCondition(ow => ow.OwnerId.Equals(id))
            .FirstOrDefaultAsync();

    public async Task<Owner> GetOwnerWithDetailsAsync(Guid id)
        =>
            await GetByCondition(ow => ow.OwnerId.Equals(id))
            .Include(acc => acc.Accounts)
            .FirstOrDefaultAsync();

    public void InsertOwner(Owner owner)
        => Insert(owner);

    public void UpdateOwner(Owner owner)
        => Update(owner);

    public void DeleteOwner(Owner owner)
        => Delete(owner);

    public async Task<IEnumerable<Owner>> GetOwnersWithPaginationAsync(OwnersParameters ownersParameters)
        =>
            await GetAll()
            .OrderBy(e => e.Name)
            .Skip((ownersParameters.PageNumber - 1) * ownersParameters.PageSize)
            .Take(ownersParameters.PageSize)
            .ToListAsync();
}
