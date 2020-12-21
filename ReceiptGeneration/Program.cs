using MamSalesTaxes.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingStore store = new ShoppingStore();
            store.GetSalesOrder();
            store.CheckOut();

            Console.ReadKey();
        }
    }
}
