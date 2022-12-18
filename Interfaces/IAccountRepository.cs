using AccountApi.Models;

namespace AccountApi.Interfaces;

public interface IAccountRepository : IGenericRepository<Account>
{
    Task<IEnumerable<Account>> GetAccountsAsync();
    Task<Account> GetAccountByIdAsync(Guid id);
    Task<IEnumerable<Account>> GetAccountsByOwner(Guid ownerId);

    void InsertAccount(Account account);
    void UpdateAccount(Account account);
    void DeleteAccount(Account account);
}
