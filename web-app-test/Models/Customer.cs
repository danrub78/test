using System;
namespace web_app_test.Models
{

    public class Customer
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
