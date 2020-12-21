using MamSalesTaxes.Products;


namespace MamSalesTaxes.ProductFactories
{
    public abstract class ProductFactory
    {
        public abstract Product CeateProduct(string name, double price, bool imported, int quantity);
    }
}
