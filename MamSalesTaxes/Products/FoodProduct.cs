using MamSalesTaxes.ProductFactories;
using MamSalesTaxes.TaxCalculation;
using System;

namespace MamSalesTaxes.Products
{
    public class FoodProduct : Product
    {
        public FoodProduct() : base()
        {
        }
        public FoodProduct(String name, double price, bool imported, int quantity) : base(name, price, imported, quantity)
        {
        }
        public override ProductFactory GetFactory()
        {
            return new FoodProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
            {
                return LocalTaxValues.FOOD_TAX;
            }
            return 0;
        }
    }
}
