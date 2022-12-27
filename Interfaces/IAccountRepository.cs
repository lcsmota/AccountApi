using AccountApi.Models;
using AccountApi.Pagination;

namespace AccountApi.Interfaces;

public interface IAccountRepository
{
    Task<IEnumerable<Account>> GetAccountsAsync();
    Task<Account> GetAccountByIdAsync(Guid id);
    Task<IEnumerable<Account>> GetAccountsByOwner(Guid ownerId);

    void InsertAccount(Account account);
    void UpdateAccount(Account account);
    void DeleteAccount(Account account);

    Task<PagedList<Account>> GetAccountsWithPaginationAsync(AccountsParameters accountParameters);
    Task<PagedList<Account>> GetAccountsWithFilteringAsync(AccountsParameters accountParameters);
    Task<PagedList<Account>> GetAccountsWithSearchingAsync(AccountsParameters accountParameters);
}
