using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.src.model
{
    public class Account
    {
        public static int AmountOfAccount { get; protected set; }

        public int Id { get; protected set; }

        private Customer _customer;
        public Customer Customer {
            get
            {
                // Console.WriteLine("titulaire a ete appele");
                return this._customer;
            }
            protected set
            {
                // Console.WriteLine("titulaire a ete change en " + value);
                this._customer = value;
            }
        }

        public string Devise { get; set; }
        public double Sold { get; set; }

        public Account(Customer customer)
        {
            this.Customer = customer;
            this.Sold = 0;
            this.Devise = "$";
            AmountOfAccount++;
            this.Id = AmountOfAccount;
        }

        public Account(string FirstName, string LastName) : this(new Customer(FirstName, LastName))
        {
        }

        public void Crediter(double amount)
        {
            this.Sold += amount;
        }

        public void Debiter(double amount)
        {
            this.Sold -= amount;
        }

        public void PrintStatus()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return ("Compte bancaire de " + this.Customer + " (id: " + this.Id + ")" + "\n-> " + this.Sold + this.Devise + "\n");
        }

    }
}
