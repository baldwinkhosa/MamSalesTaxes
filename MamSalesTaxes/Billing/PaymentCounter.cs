using MamSalesTaxes.Products;
using MamSalesTaxes.Shopping;
using MamSalesTaxes.TaxCalculation;
using System.Collections.Generic;

namespace MamSalesTaxes.Billing
{
    public class PaymentCounter
    {
        private Biller biller;
        private Receipt receipt;
        private List<Product> productList;
        private string _country;

        public PaymentCounter(string country)
        {
            _country = country;
        }

        public void BillItemsInCart(ShoppingCart cart)
        {
            productList = cart.GetItemsFromCart();

            foreach (Product p in productList)
            {
                biller = GetBiller(_country);
                double productTax = biller.CalculateTax(p.Price, p.GetTaxValue(_country), p.Imported);
                double taxedCost = biller.CalcTotalProductCost(p.Price, productTax);
                p.TaxedCost = taxedCost;
            }
        }

        public Receipt GetReceipt()
        {
            double totalTax = biller.CalcTotalTax(productList);
            double totalAmount = biller.CalcTotalAmount(productList);
            receipt = biller.CreateNewReceipt(productList, totalTax, totalAmount);
            return receipt;
        }

        public void PrintReceipt(Receipt receipt)
        {
            biller.GenerateReceipt(receipt);
        }

        public Biller GetBiller(string strategy)
        {
            TaxCalculatorFactory factory = new TaxCalculatorFactory();
            ITaxCalculator taxCal = factory.GetTaxCalculator(strategy);
            return new Biller(taxCal);
        }
    }


}
