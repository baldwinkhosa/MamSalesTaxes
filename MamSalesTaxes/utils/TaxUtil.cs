using System;

namespace MamSalesTaxes.utils
{
    public class TaxUtil
    {
        private const double ROUND_OFF = 0.05;
        public static double RoundOff(double value)
        {
            return (int)(value / ROUND_OFF + 0.5) * 0.05;
        }
        public static double Truncate(double value)
        {
            string result = value.ToString("N2"); ;
            return double.Parse(result);
        }
        public static bool ParseBoolean(char value)
        {
            bool flag = true;
            bool boolValue = false;

            while (flag)
            {
                if (value == 'Y' || value == 'y')
                {
                    boolValue = true;
                    flag = false;
                }
                else if (value == 'N' || value == 'n')
                {
                    boolValue = false;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter (Y/N)");
                }
            }
            return boolValue;
        }
    }
}
