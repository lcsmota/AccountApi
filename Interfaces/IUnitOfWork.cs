namespace AccountApi.Interfaces;

public interface IUnitOfWork
{
    IOwnerRepository OwnerRepository { get; }
    IAccountRepository AccountRepository { get; }
    Task CommitAsync();
}
