using MamSalesTaxes.Products;

namespace MamSalesTaxes.ProductFactories
{
    public class MiscellaneousProductFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool imported, int quantity)
        {
            return new MiscellaneousProduct(name, price, imported, quantity);
        }
    }
}
