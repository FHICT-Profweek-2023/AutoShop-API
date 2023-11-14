namespace AutoShop_API.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string First_Name { get; set; }

        public string Last_Name { get; set;}

        public string Email { get; set; }

        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime Register_Date { get; set; }
    }
}
