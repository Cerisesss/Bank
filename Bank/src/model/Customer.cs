using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.src.model
{
    public class Customer
    {
        public static int AmountOfCustomer;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AmountOfCustomer++;
            this.Id = AmountOfCustomer;
        }



    }
}
