using System;

namespace ExchangeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            ExchangeMonitor em = new ExchangeMonitor();

            bool optOut = false;

            while (!optOut)
            {

                Console.WriteLine(" What would you like to do?");
                Console.WriteLine("(E)xchange Currency | (O)pt out");
                keyInfo = Console.ReadKey();

                //Exchange Currency
                if (keyInfo.Key == ConsoleKey.E)
                {
                    Console.Clear();
                    Console.WriteLine("What type of currency would you like to use?");
                    Console.WriteLine("(U)SD (G)BP (C)AN (E)UR");
                    keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.U)
                    {
                        DoUSDLogic(em, keyInfo);
                    }
                    else if (keyInfo.Key == ConsoleKey.G)
                    {
                        DoGBPLogic(em, keyInfo);
                    }
                    else if (keyInfo.Key == ConsoleKey.C)
                    {
                        DoCANLogic(em, keyInfo);
                    }
                    else if (keyInfo.Key == ConsoleKey.E)
                    {
                        DoEURLogic(em, keyInfo);
                    }
                }

                //Opt out
                else if (keyInfo.Key == ConsoleKey.O)
                {
                    Console.WriteLine("\n" + em.GetReport());
                    optOut = true;

                }
            }

            Console.Read();
        }

        private static void DoUSDLogic(ExchangeMonitor em, ConsoleKeyInfo keyInfo)
        {
            Console.WriteLine("\nWhat type of currency would you like to exchange for?");
            Console.WriteLine("(G)BP (C)AN (E)UR");
            keyInfo = Console.ReadKey();

            //USD to GBP
            if (keyInfo.Key == ConsoleKey.G)
            {
                ExchangeLogic(em, "USD", "GBP");
            }

            //USD to CAN
            else if (keyInfo.Key == ConsoleKey.C)
            {
                ExchangeLogic(em, "USD", "CAN");
            }

            //USD to EUR
            else if (keyInfo.Key == ConsoleKey.E)
            {
                ExchangeLogic(em, "USD", "EUR");
            }
        }

        private static void DoGBPLogic(ExchangeMonitor em, ConsoleKeyInfo keyInfo)
        {
            Console.WriteLine("\nWhat type of currency would you like to exchange for?");
            Console.WriteLine("(U)SD (C)AN (E)UR");
            keyInfo = Console.ReadKey();

            //GBP to USD
            if (keyInfo.Key == ConsoleKey.U)
            {
                ExchangeLogic(em, "GBP", "USD");
            }

            //GBP to CAN
            else if (keyInfo.Key == ConsoleKey.C)
            {
                ExchangeLogic(em, "GBP", "CAN");
            }

            //GBP to EUR
            else if (keyInfo.Key == ConsoleKey.E)
            {
                ExchangeLogic(em, "GBP", "EUR");
            }
        }

        private static void DoCANLogic(ExchangeMonitor em, ConsoleKeyInfo keyInfo)
        {
            Console.WriteLine("\nWhat type of currency would you like to exchange for?");
            Console.WriteLine("(G)BP (U)SD (E)UR");
            keyInfo = Console.ReadKey();

            //CAN to USD
            if (keyInfo.Key == ConsoleKey.U)
            {
                ExchangeLogic(em, "CAN", "USD");
            }

            //CAN to GBP
            else if (keyInfo.Key == ConsoleKey.G)
            {
                ExchangeLogic(em, "CAN", "GBP");
            }

            //CAN to EUR
            else if (keyInfo.Key == ConsoleKey.E)
            {
                ExchangeLogic(em, "CAN", "EUR");
            }
        }

        private static void DoEURLogic(ExchangeMonitor em, ConsoleKeyInfo keyInfo)
        {
            Console.WriteLine("\nWhat type of currency would you like to exchange for?");
            Console.WriteLine("(G)BP (U)SD (C)AN");
            keyInfo = Console.ReadKey();

            //EUR to USD
            if (keyInfo.Key == ConsoleKey.U)
            {
                ExchangeLogic(em, "EUR", "USD");
            }

            //EUR to GBP
            else if (keyInfo.Key == ConsoleKey.G)
            {
                ExchangeLogic(em, "EUR", "GBP");
            }

            //EUR to CAN
            else if (keyInfo.Key == ConsoleKey.C)
            {
                ExchangeLogic(em, "EUR", "CAN");
            }
        }

        private static void ExchangeLogic(ExchangeMonitor em, string trading, string obtaining)
        {
            Console.Write("\nEnter amount: ");
            string s = Console.ReadLine();
            double amount = double.Parse(s);

            em.MakeExchange(amount, trading, obtaining);
            Console.WriteLine("Exchanged amount: " + em.CurrentExchange + "\n");

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

