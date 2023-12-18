﻿namespace AutoShop_API.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string? FirstName { get; set; }

        public string? LastName { get; set;}

        public string? Email { get; set; }

        public string? Gender { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
