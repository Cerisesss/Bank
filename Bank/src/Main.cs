using Bank.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.src
{
    public class main
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account("Celive");
            Account a2 = new Account("Lea");
            Account a3 = new Account("Paul");
            a1.Crediter(60);

            a1.PrintStatus();
            a3.PrintStatus();
            a2.PrintStatus();
        }
    }
}
