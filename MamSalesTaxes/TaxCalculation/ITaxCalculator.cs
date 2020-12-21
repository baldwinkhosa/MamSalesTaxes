namespace MamSalesTaxes.TaxCalculation
{
    public interface ITaxCalculator
    {
        double CalculateTax(double price, double tax, bool imported);
    }
}
