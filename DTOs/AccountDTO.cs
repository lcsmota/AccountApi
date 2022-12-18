namespace AccountApi.DTOs;

public class AccountDTO
{
    public Guid AccountId { get; set; }
    public DateTime DateCreated { get; set; }
    public string? AccountType { get; set; }
    public Guid OwnerId { get; set; }
}
