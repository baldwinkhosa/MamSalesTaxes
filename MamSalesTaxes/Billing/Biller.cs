using MamSalesTaxes.Products;
using MamSalesTaxes.TaxCalculation;
using MamSalesTaxes.utils;
using System;
using System.Collections.Generic;

namespace MamSalesTaxes.Billing
{
    public class Biller
    {
       private readonly ITaxCalculator _taxCalculator;

        public Biller(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
        public double CalculateTax(double price, double tax, bool imported)
        {
            return _taxCalculator.CalculateTax(price, tax, imported);
        }
        public double CalcTotalProductCost(double price, double tax)
        {
            return TaxUtil.Truncate(price + tax);
        }
        public double CalcTotalTax(List<Product> prodList)
        {
            double totalTax = 0.0;

            foreach (Product p in prodList)
            {
                totalTax += (p.TaxedCost - p.Price);
            }

            return TaxUtil.Truncate(totalTax);
        }
        public double CalcTotalAmount(List<Product> prodList)
        {
            double totalAmount = 0.0;

            foreach (Product p in prodList)
            {
                totalAmount += p.TaxedCost;
            }

            return TaxUtil.Truncate(totalAmount);
        }
        public Receipt CreateNewReceipt(List<Product> productList, double totalTax, double totalAmount)
        {
            return new Receipt(productList, totalTax, totalAmount);
        }
        public void GenerateReceipt(Receipt receipt)
        {
            Console.WriteLine(receipt.ToString());
        }

    }
}
