using System.Collections.Generic;

namespace MamSalesTaxes.TaxCalculation
{
    public class TaxCalculatorFactory
    {
        private Dictionary<string, ITaxCalculator> taxCalculators;

        public TaxCalculatorFactory()
        {
            taxCalculators = new Dictionary<string, ITaxCalculator>();
            RegisterInFactory("Local", new LocalTaxCalculator());
        }
        public void RegisterInFactory(string strategy, ITaxCalculator taxCalc)
        {
            taxCalculators.Add(strategy, taxCalc);
        }
        public ITaxCalculator GetTaxCalculator(string strategy)
        {
            ITaxCalculator taxCalc = (ITaxCalculator)taxCalculators[strategy];
            return taxCalc;
        }
        public int GetFactorySize()
        {
            return taxCalculators.Count;
        }
    }
}
