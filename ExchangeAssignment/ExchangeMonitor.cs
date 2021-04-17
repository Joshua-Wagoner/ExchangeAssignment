using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeAssignment
{
    public class ExchangeMonitor
    {
        private int exchanges;
        private double totalCurrency;
        private double currentExchange;

        public int Exchanges { get { return exchanges; } }
        public double CurrentExchange
        {
            get
            { return currentExchange; }

            private set
            { currentExchange = value; }
        }
        public double TotalCurrency { get { return totalCurrency; } }

        public void MakeExchange(double amount, string currencyTraded, string currencyObtaining)
        {
            exchanges++;

            double convertedAmount = 0;

            if (currencyTraded == "USD")
            {
                totalCurrency += amount;

                convertedAmount = ExchangeUSD(amount, currencyObtaining);
            }

            else if (currencyTraded == "GBP")
            {
                convertedAmount = ExchangeGBP(amount, currencyObtaining);
            }

            else if (currencyTraded == "CAN")
            {
                convertedAmount = ExchangeCAN(amount, currencyObtaining);
            }

            else if (currencyTraded == "EUR")
            {
                convertedAmount = ExchangeEUR(amount, currencyObtaining);
            }

            CurrentExchange = convertedAmount;
        }

        public string GetReport()
        {
            string report = "";

            if (totalCurrency < 1)
            {
                report = string.Format("Total Currency (USD): {0:.00}", TotalCurrency);
            }
            else if (totalCurrency >= 1)
            {
                report = string.Format("Total Currency (USD): {0:C}", TotalCurrency);
            }

            report += "\nExchanges: " + Exchanges;

            return report;
        }

        private double ExchangeUSD(double amount, string currencyType)
        {
            double convertedAmount = 0;

            if (currencyType == "GBP")
            {
                convertedAmount = Exchanger.ConvertUSDtoGBP(amount);
            }
            else if (currencyType == "CAN")
            {
                convertedAmount = Exchanger.ConvertUSDtoCAN(amount);
            }
            else if (currencyType == "EUR")
            {
                convertedAmount = Exchanger.ConvertUSDtoEUR(amount);
            }

            return convertedAmount;
        }
        private double ExchangeGBP(double amount, string currencyType)
        {
            double convertedAmount = 0;

            if (currencyType == "USD")
            {
                convertedAmount = Exchanger.ConvertGBPtoUSD(amount);
                totalCurrency += convertedAmount;
            }
            else if (currencyType == "CAN")
            {
                convertedAmount = Exchanger.ConvertGBPtoCAN(amount);
                totalCurrency += Exchanger.ConvertGBPtoUSD(amount);
            }
            else if (currencyType == "EUR")
            {
                convertedAmount = Exchanger.ConvertGBPtoEUR(amount);
                totalCurrency += Exchanger.ConvertGBPtoUSD(amount);
            }

            return convertedAmount;
        }
        private double ExchangeCAN(double amount, string currencyType)
        {
            double convertedAmount = 0;

            if (currencyType == "USD")
            {
                convertedAmount = Exchanger.ConvertCANtoUSD(amount);
                totalCurrency += convertedAmount;
            }
            else if (currencyType == "GBP")
            {
                convertedAmount = Exchanger.ConvertCANtoGBP(amount);
                totalCurrency += Exchanger.ConvertCANtoUSD(amount);
            }
            else if (currencyType == "EUR")
            {
                convertedAmount = Exchanger.ConvertCANtoEUR(amount);
                totalCurrency += Exchanger.ConvertCANtoUSD(amount);
            }

            return convertedAmount;
        }
        private double ExchangeEUR(double amount, string currencyType)
        {
            double convertedAmount = 0;

            if (currencyType == "USD")
            {
                convertedAmount = Exchanger.ConvertEURtoUSD(amount);
                totalCurrency += convertedAmount;
            }
            else if (currencyType == "GBP")
            {
                convertedAmount = Exchanger.ConvertEURtoGBP(amount);
                totalCurrency += Exchanger.ConvertEURtoUSD(amount);
            }
            else if (currencyType == "CAN")
            {
                convertedAmount = Exchanger.ConvertEURtoCAN(amount);
                totalCurrency += Exchanger.ConvertEURtoUSD(amount);
            }

            return convertedAmount;
        }

    }
}

