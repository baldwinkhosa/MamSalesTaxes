using MamSalesTaxes.Products;

namespace MamSalesTaxes.ProductFactories
{
    public class FoodProductFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool imported, int quantity)
        {
            return new FoodProduct(name, price, imported, quantity);
        }
    }
}
