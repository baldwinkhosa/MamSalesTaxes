using MamSalesTaxes.Products;

namespace MamSalesTaxes.ProductFactories
{
    public class MedicalProductFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool imported, int quantity)
        {
            return new MedicalProduct(name, price, imported, quantity);
        }
    }
}
