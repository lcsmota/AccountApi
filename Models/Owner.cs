namespace AccountApi.Models;

public class Owner
{
    public Guid OwnerId { get; set; }
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; }

    public ICollection<Account> Accounts { get; set; } = new List<Account>();
}
