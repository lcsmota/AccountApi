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

    public async Task<PagedList<Owner>> GetOwnersWithPaginationAsync(OwnersParameters ownersParameters)
        =>
            await PagedList<Owner>.ToPagedList(
                GetAll().OrderBy(e => e.Name),
                ownersParameters.PageNumber,
                ownersParameters.PageSize);

    public async Task<PagedList<Owner>> GetOwnersWithFilteringAsync(OwnersParameters ownersParameters)
    {
        var owners = GetByCondition(e => e.DateOfBirth.Year >= ownersParameters.MinYearOfBirth &&
                        e.DateOfBirth.Year <= ownersParameters.MaxYearOfBirth)
                        .OrderBy(name => name.Name);

        return await PagedList<Owner>.ToPagedList(owners, ownersParameters.PageNumber, ownersParameters.PageSize);
    }

    public async Task<PagedList<Owner>> GetOwnersWithSearchingAsync(OwnersParameters ownersParameters)
    {
        var owners = GetByCondition(e =>
            e.DateOfBirth.Year >= ownersParameters.MinYearOfBirth &&
            e.DateOfBirth.Year <= ownersParameters.MaxYearOfBirth);

        SearchByName(ref owners, ownersParameters.Name);

        return await PagedList<Owner>.ToPagedList(
            owners.OrderBy(ow => ow.DateOfBirth),
            ownersParameters.PageNumber,
            ownersParameters.PageSize);
    }

    private void SearchByName(ref IQueryable<Owner> owners, string ownerName)
    {
        if (!owners.Any() || string.IsNullOrWhiteSpace(ownerName))
            return;

        owners = owners.Where(e => e.Name.ToLower().Contains(ownerName.ToLower().Trim()));
    }
}
