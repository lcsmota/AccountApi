using AccountApi.Context;
using AccountApi.Interfaces;

namespace AccountApi.Repository;

public class UnitOfWork : IUnitOfWork
{
    private IOwnerRepository _ownerRep;
    private IAccountRepository _accountRep;

    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IOwnerRepository OwnerRepository
        => _ownerRep ??= new OwnerRepository(_context);

    public IAccountRepository AccountRepository
        => _accountRep ??= new AccountRepository(_context);


    public Task CommitAsync()
        => _context.SaveChangesAsync();

    public void Dispose()
        => _context.Dispose();
}
