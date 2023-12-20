# API

The following APIs are available:

* Products, at: ``http://your-ip/api/products``, or: ``http://your-ip/api/products/{id}``

      {

        int id,

        string name,

        string description,

        int price

      }

* Customers, at: ``http://your-ip/api/customers``, or: ``http://your-ip/api/customers/{id}``

      {

        int id,

        string first_name,

        string last_name,

        string email,

        string gender,

        DateTime birthday

        DateTime register_date

      }

* Controls, at: ``http://your-ip/api/controls/{id}``

      {
        int id,
  
        bool halt,
  
        int? next_product, // Nullable
  
        int current_position
  
      }

* Credentials, at: ``http://your-ip/api/credentials/{username}&{password}``

      {
        int id,
  
        string username,
  
        string password
  
      }
