namespace AutoShop_API.Models
{
    public class Control
    {
        public int Id { get; set; }

        public int? Next_Product { get; set; }

        public int Current_Position { get; set; }

        public bool halt { get; set; }
    }
}
