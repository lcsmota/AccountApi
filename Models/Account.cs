namespace AccountApi.Models;

public class Account
{
    public Guid AccountId { get; set; }
    public DateTime DateCreated { get; set; }
    public string? AccountType { get; set; }

    public Guid OwnerId { get; set; }
    public Owner? Owner { get; set; }
}
