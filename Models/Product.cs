namespace AutoShop_API.Models;

public class Product
{
    public int Id { get; init; }

    public required string Name { get; init; }

    public required string Description { get; init; }

    public required int Price { get; init; }
}