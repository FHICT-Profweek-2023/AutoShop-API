# API

The following APIs are available:

* Products

      {

        int id,

        string name,

        string description,

        int price

      }

* Customers

      {

        int id,

        string first_name,

        string last_name,

        string email,

        string gender,

        DateTime birthday

        DateTime register_date

      }

* Controls

      {
        int id,
  
        bool halt,
  
        int next_product,
  
        int current_position
  
      }
