using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeAssignment
{
    public static class Exchanger
    {

        //USD Conversion Methods
        public static double ConvertUSDtoGBP(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertUSD(amount, "GBP"));
        }

        public static double ConvertUSDtoCAN(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertUSD(amount, "CAN"));
        }

        public static double ConvertUSDtoEUR(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertUSD(amount, "EUR"));
        }

        //Conversion for USD
        private static double ConvertUSD(double amount, string type)
        {
            double conversion = 0;

            if (type == "GBP")
            {
                conversion = amount * 0.72523;
            }
            else if (type == "CAN")
            {
                conversion = amount * 1.25427;
            }
            else if (type == "EUR")
            {
                conversion = amount * 0.83572;
            }

            return conversion;
        }

        //GBP Conversion Methods
        public static double ConvertGBPtoUSD(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertGBP(amount, "USD"));
        }

        public static double ConvertGBPtoCAN(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertGBP(amount, "CAN"));
        }

        public static double ConvertGBPtoEUR(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertGBP(amount, "EUR"));
        }

        //Conversion for GBP
        private static double ConvertGBP(double amount, string type)
        {
            double conversion = 0;

            if (type == "USD")
            {
                conversion = amount * 1.37887;
            }
            else if (type == "CAN")
            {
                conversion = amount * 1.72947;
            }
            else if (type == "EUR")
            {
                conversion = amount * 1.15195;
            }

            return conversion;
        }

        //CAN Conversion Methods
        public static double ConvertCANtoUSD(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertCAN(amount, "USD"));
        }

        public static double ConvertCANtoGBP(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertCAN(amount, "GBP"));
        }

        public static double ConvertCANtoEUR(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertCAN(amount, "EUR"));
        }

        //Conversion for CAN
        private static double ConvertCAN(double amount, string type)
        {
            double conversion = 0;

            if (type == "USD")
            {
                conversion = amount * 0.79728;
            }
            else if (type == "GBP")
            {
                conversion = amount * 0.57848;
            }
            else if (type == "EUR")
            {
                conversion = amount * 0.66645;
            }

            return conversion;
        }

        //EUR Conversion Methods
        public static double ConvertEURtoUSD(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertEUR(amount, "USD"));
        }

        public static double ConvertEURtoGBP(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertEUR(amount, "GBP"));
        }

        public static double ConvertEURtoCAN(double amount)
        {
            return LimitToTwoSignificantDigits(ConvertEUR(amount, "CAN"));
        }

        //Conversion for EUR
        private static double ConvertEUR(double amount, string type)
        {
            double conversion = 0;

            if (type == "USD")
            {
                conversion = amount * 1.19648;
            }
            else if (type == "GBP")
            {
                conversion = amount * 0.86826;
            }
            else if (type == "CAN")
            {
                conversion = amount * 1.50040;
            }

            return conversion;
        }

        //Limits the outputs of the conversions to two significant digits.
        private static double LimitToTwoSignificantDigits(double amount)
        {
            string s = string.Format("{0:G" + 2 + "}", amount);
            double d = double.Parse(s);
            return d;
        }
    }
}
