using System;

namespace Voting_Calculator
{
    class Country_data
    {
        public static void Main()
        {
            string country = System.IO.File.ReadAllText(@"C:\Users\ODSTc\source\repos\Voting Calculator\Voting Calculator\Country Data.txt");
            Console.WriteLine("Contents of Country Data.txt = {0}", country);

        }
    }

}