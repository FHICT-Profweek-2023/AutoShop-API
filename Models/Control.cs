namespace AutoShop_API.Models
{
    public class Control
    {
        public int Id { get; set; }

        public int? next_product { get; set; }

        public int current_position { get; set; }

        public bool Halt { get; set; }
    }
}
