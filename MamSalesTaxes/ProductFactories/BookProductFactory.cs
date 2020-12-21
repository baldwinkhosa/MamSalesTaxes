using MamSalesTaxes.Products;

namespace MamSalesTaxes.ProductFactories
{
    public class BookProductFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool imported, int quantity)
        {
            return new Products.BookProduct(name, price, imported, quantity);
        }
    }
}
