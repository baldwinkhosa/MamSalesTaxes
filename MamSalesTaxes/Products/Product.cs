using MamSalesTaxes.ProductFactories;
using System;

namespace MamSalesTaxes.Products
{
    public abstract class Product
    {
        protected string Name { get; set; }

        private double _price;
        public double Price
        {
            set { _price = value; }
            get { return _price * Quantity; }
        }
        public int Quantity { get; set; }
        public double TaxedCost { get; set; }
        public bool Imported { get; set; }
        public Product()
        {
            Name = string.Empty;
            Price = 0.0;
            Imported = false;
            Quantity = 0;
            TaxedCost = 0.0;
        }
        public Product(string name, double price, bool imported, int quantity)
        {
            Name = name;
            Price = price;
            Imported = imported;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return ($"{Quantity} {ImportedToString(Imported)} {Name} : {TaxedCost}");
        }
        public string ImportedToString(bool imported)
        {
            if (imported)
            {
                return "imported"; 
            }
            return string.Empty;
        }
        public abstract ProductFactory GetFactory();
        public abstract double GetTaxValue(string country);
    }
}
