using System;
using System.Security.Cryptography;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = 0;
            double gallons = 0.0;
            double mpg;
            string temp;
            //read in the miles
            miles = getInt("Enter miles:");
            //read in the gallons
            Console.WriteLine("Enter Gallons):");
            temp = Console.ReadLine();
            gallons = double.Parse(temp);
            //compute mpg
            mpg = miles / gallons;
            Console.WriteLine("You Got " + mpg + " mpg");



        }

        public static int getInt(string prompt)
        {
            string temp;
            int value;
            Console.WriteLine(prompt);
            temp = Console.ReadLine();
            value = Int32.Parse(temp);
            return value;

        }
    }
}
