
using System;

namespace MoneyMaker
{
    //This program will request the user to input an "x" cent amount and it will convert it to their equivalent in gold, silver and bronze coins//
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coin Exchanger! This program will convert cents into the minimum number of coins that equal that value");
            Console.WriteLine("Enter a cent amount and press enter: ");
            string amount = Console.ReadLine();
            //convert the string into a double 
            double nAmount = Convert.ToDouble(amount);

            Console.WriteLine(amount + " cents is equal to...");
            //gold coin is 10 cents
            double gCoin = 10;
            //silver coin is 5 cents
            double sCoin = 5;

            //will divide the entered amount by the gold coing value
            double goldCoins = Math.Floor(nAmount / gCoin);
            double gleftOver = nAmount % 10;

            //will divide the remained from gold between the silver coin value
            double silverCoins = Math.Floor(gleftOver / sCoin);
            double sleftOver = gleftOver % 5;

            Console.WriteLine("Gold Coins: " + goldCoins);
            //  Console.WriteLine(gleftOver);//to check the remaining for accuracy //
            Console.WriteLine("Silver Coins: " + silverCoins);
            Console.WriteLine("Bronze Coins: " + sleftOver);

        }
    }
}
