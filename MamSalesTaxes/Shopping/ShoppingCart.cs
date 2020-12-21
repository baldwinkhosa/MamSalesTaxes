using MamSalesTaxes.Products;
using System.Collections.Generic;

namespace MamSalesTaxes.Shopping
{
    public class ShoppingCart
    {
        private List<Product> productList { get; set; }
        public ShoppingCart()
        {
            productList = new List<Product>();
        }
        public void AddItemToCart(Product product)
        {
            productList.Add(product);
        }
        public List<Product> GetItemsFromCart()
        {
            return productList;
        }
        public int GetCartSize()
        {
            return productList.Count;
        }
    }
}
