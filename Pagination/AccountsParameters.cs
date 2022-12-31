namespace AccountApi.Pagination;

public class AccountsParameters : QueryStringParameters
{
    public uint MinDateCreated { get; set; }
    public uint MaxDateCreated { get; set; } = (uint)DateTime.Now.Year;

    public bool ValidDateRange => MinDateCreated < MaxDateCreated;

    public string? AccountType { get; set; }
}
