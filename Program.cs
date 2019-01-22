using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Tax % \n");
            string tax_percent = Console.ReadLine();
            Console.WriteLine("Tax % Chosen: " + tax_percent + "\n");
            Console.WriteLine("Please enter an amount: \n");
            string amount = Console.ReadLine();
            Console.WriteLine("Amount chosen: " + amount + "\n");

            int a = Convert.ToInt32(amount) * Convert.ToInt32(tax_percent) / 100;

            int amount_tax = Convert.ToInt32(amount) + a;

            Console.WriteLine("Amount with tax: " + amount_tax.ToString());
            Thread.Sleep(4);
            Console.ReadLine();


        }
    }
}
