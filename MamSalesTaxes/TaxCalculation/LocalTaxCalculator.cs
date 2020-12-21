using MamSalesTaxes.utils;
namespace MamSalesTaxes.TaxCalculation
{
    public class LocalTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double price, double tax, bool imported)
        {
            double totalTax = price * tax;

            if (imported)
            {
                totalTax += (price * 0.5);
            }

            totalTax = TaxUtil.RoundOff(totalTax);
            return totalTax;
        }
    }
}
