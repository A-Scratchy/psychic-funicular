using System;
using RetailApp.Domain.Models;

namespace RetailApp.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiptOne = new ReceiptModel(
                1, new DateTime(), 123, "Charles Barkley",
                new AddressModel(), 12334, 9, "Golden Shoes",
                210.50m, 2);
            Console.WriteLine(receiptOne.ToString());
        }
    }
}
