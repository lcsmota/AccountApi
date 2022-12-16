using AccountApi.Context;
using AccountApi.Interfaces;
using AccountApi.Models;

namespace AccountApi.Repository;

public class AccountRepository : GenericRepository<Account>, IAccountRepository
{
    public AccountRepository(AppDbContext context)
        : base(context) { }
}
