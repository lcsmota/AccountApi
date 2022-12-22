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

    public async Task<PagedList<Account>> GetAccountsWithPagination(AccountsParameters accountParameters)
        =>
            await PagedList<Account>.ToPagedList(
                GetAll().OrderBy(e => e.AccountType),
                accountParameters.PageNumber,
                accountParameters.PageSize);
}
