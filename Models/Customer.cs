namespace AutoShop_API.Models;

public class Customer
{
    public int Id { get; init; }
        
    public required string First_Name { get; init; }

    public required string Last_Name { get; init; }

    public required string Email { get; init; }

    public required string Gender { get; init; }

    public required string Birthday { get; init; }

    public DateTime? Register_Date { get; init; }
    
    public required string Country { get; init; }
        
    public required string Adress { get; init; }
        
    public required string Postalcode { get; init; }
}