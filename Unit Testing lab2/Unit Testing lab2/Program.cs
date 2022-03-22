using System;

namespace Unit_Testing_lab2
{
    public class Program
    {
        public static decimal Balance = 2000;
        static void Main(string[] args)
        {
            UserInterface();
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal WithDraw(decimal input)
        {
            if (input > Balance)
            {
                Console.WriteLine("the Balance is not that big");
                return Balance;
            }
            else if (input < 0)
            {
                Console.WriteLine("you cant WithDraw a negative value");
                return Balance;
            }
            else {
                Balance -= input;
                Console.WriteLine("the new Balance is "+ Balance);
                return Balance;
                
            }
        }
        public static decimal Deposit(decimal input)
        {
            if (input < 0)
            {
                Console.WriteLine("you cant Deposit a negative value");
                return Balance;
            }
            else
            {
                Balance += input;
                Console.WriteLine("the new Balance is "+Balance);
                return Balance;
            }
        }

        public static void UserInterface()
        {
            Decimal useroperation = 0 ;
            while (true)
            {
                Console.WriteLine("Choose the operation numberto start");
                Console.WriteLine("1- Deposit");
                Console.WriteLine("2- Withdraw");
                Console.WriteLine("3- View Balance");
                Console.WriteLine("4- Exit");
                decimal value = 0;
                Decimal.TryParse(Console.ReadLine(), out useroperation);
                if (useroperation < 0)
                {
                    Console.WriteLine("please chose frome the correct operation number ");
                }
                else
                {
                    switch (useroperation)
                    {
                        case 1:
                            {
                                Console.WriteLine("please enter how math you want to deposit");
                                Decimal.TryParse(Console.ReadLine(), out value);
                                Deposit(value);
                                break;
                            }case 2:
                            {
                                Console.WriteLine("please enter how math you want to withdraw");
                                Decimal.TryParse(Console.ReadLine(), out value);
                                WithDraw(value);
                                break;
                            }case 3:
                            {
                                ViewBalance();
                                Console.WriteLine("your balance is " + Balance);
                                break;

                            }case 4:
                            {
                                Console.WriteLine("thank you fore shoseing us");
                                Environment.Exit(0);
                                
                                break;
                            }
                    }
                }
            }
        }

    }
}
