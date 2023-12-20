namespace AutoShop_API.Models;

public class Credential
{
    public int Id { get; init; }
    public required string Email { get; init; }
    public required string Password { get; init; }
}