namespace AccountApi.Pagination;

public class OwnersParameters : QueryStringParameters
{
    public uint MinYearOfBirth { get; set; }
    public uint MaxYearOfBirth { get; set; } = (uint)DateTime.UtcNow.Year;

    public bool ValidYearRange => MaxYearOfBirth > MinYearOfBirth;
}
