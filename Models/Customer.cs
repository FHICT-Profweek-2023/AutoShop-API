namespace AutoShop_API.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string? first_Name { get; set; }

        public string? last_Name { get; set;}

        public string? email { get; set; }

        public string? gender { get; set; }

        public DateTime birthday { get; set; }

        public DateTime register_Date { get; set; }
        
        public string adress { get; set; }
        
        public string postalcode { get; set; }
    }
}
