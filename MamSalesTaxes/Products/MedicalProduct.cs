using MamSalesTaxes.ProductFactories;
using MamSalesTaxes.TaxCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamSalesTaxes.Products
{
    public class MedicalProduct : Product
    {
        public MedicalProduct() : base()
        {
        }
        public MedicalProduct(string name, double price, bool imported, int quantity) : base(name, price, imported, quantity)
        {
        }
        public override ProductFactory GetFactory()
        {
            return new MedicalProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
            {
                return LocalTaxValues.MEDICAL_TAX;
            }
            return 0;
        }
    }
}
