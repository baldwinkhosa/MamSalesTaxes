using MamSalesTaxes.ProductFactories;
using MamSalesTaxes.TaxCalculation;
using System;

namespace MamSalesTaxes.Products
{
    public class MiscellaneousProduct : Product
    {
        public MiscellaneousProduct() : base()
        {
        }
        public MiscellaneousProduct(String name, double price, bool imported, int quantity) : base(name, price, imported, quantity)
        {
        }
        public override ProductFactory GetFactory()
        {
            return new MiscellaneousProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
            {
                return LocalTaxValues.MISC_TAX;
            }
            return 0;
        }
    }
}
