namespace AutoShop_API.Models;

public class Control
{
    public int Id { get; init; }

    public int? Next_Product { get; init; }

    public int? Current_Position { get; init; }

    public bool Halt { get; init; }
}