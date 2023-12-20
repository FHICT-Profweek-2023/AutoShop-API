namespace AutoShop_API.Models;

public class Customer
{
    public int Id { get; init; }
        
    public string? first_Name { get; init; }

    public string? last_Name { get; init;}

    public string? email { get; init; }

    public string? gender { get; init; }

    public string birthday { get; init; }

    public DateTime? register_Date { get; init; }
        
    public string adress { get; init; }
        
    public string postalcode { get; init; }
}