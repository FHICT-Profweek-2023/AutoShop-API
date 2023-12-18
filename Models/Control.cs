namespace AutoShop_API.Models
{
    public class Control
    {
        public int Id { get; set; }

        public int? NextProduct { get; set; }

        public int CurrentPosition { get; set; }

        public bool Halt { get; set; }
    }
}
