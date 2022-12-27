using AccountApi.Context;
using AccountApi.Interfaces;
using AccountApi.Models;
using AccountApi.Pagination;
using Microsoft.EntityFrameworkCore;

namespace AccountApi.Repository;

public class AccountRepository : GenericRepository<Account>, IAccountRepository
{
    public AccountRepository(AppDbContext context)
        : base(context) { }


    public async Task<Account> GetAccountByIdAsync(Guid id)
        =>
            await GetByCondition(e => e.AccountId.Equals(id))
            .FirstOrDefaultAsync();


    public async Task<IEnumerable<Account>> GetAccountsAsync()
        =>
            await GetAll()
            .OrderBy(e => e.DateCreated)
            .ToListAsync();


    public async Task<IEnumerable<Account>> GetAccountsByOwner(Guid ownerId)
        =>
            await GetByCondition(e => e.OwnerId.Equals(ownerId))
            .Include(e => e.Owner)
            .ToListAsync();


    public void InsertAccount(Account account)
        => Insert(account);


    public void UpdateAccount(Account account)
        => Update(account);


    public void DeleteAccount(Account account)
        => Delete(account);

    public async Task<PagedList<Account>> GetAccountsWithPaginationAsync(AccountsParameters accountParameters)
        =>
            await PagedList<Account>.ToPagedList(
                GetAll().OrderBy(e => e.AccountType),
                accountParameters.PageNumber,
                accountParameters.PageSize);

    public async Task<PagedList<Account>> GetAccountsWithFilteringAsync(AccountsParameters accountParameters)
    {
        var accounts = GetByCondition(e => e.DateCreated.Year >= accountParameters.MinDateCreated &&
                e.DateCreated.Year <= accountParameters.MaxDateCreated).OrderBy(x => x.AccountType);

        return await PagedList<Account>.ToPagedList(
            accounts,
            accountParameters.PageNumber,
            accountParameters.PageSize);
    }

    public async Task<PagedList<Account>> GetAccountsWithSearchingAsync(AccountsParameters accountParameters)
    {
        var accounts = GetByCondition(e =>
            e.DateCreated.Year >= accountParameters.MinDateCreated &&
            e.DateCreated.Year <= accountParameters.MaxDateCreated);

        SearchByAccountType(ref accounts, accountParameters.AccountType);

        return await PagedList<Account>.ToPagedList(
            accounts,
            accountParameters.PageNumber,
            accountParameters.PageSize);
    }

    private void SearchByAccountType(ref IQueryable<Account> accounts, string accountType)
    {
        if (!accounts.Any() || string.IsNullOrWhiteSpace(accountType))
            return;

        accounts = accounts.Where(e => e.AccountType.ToLower().Contains(accountType.ToLower().Trim()));
    }
}
