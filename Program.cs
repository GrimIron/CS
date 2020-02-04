using System;

namespace Voting_Calculator
{
    class Country
    {
        public static void get_info()
        {
            string country = System.IO.File.ReadAllText(@"C: \Users\ODSTc\Documents\GitHub\CS\Country Data.txt");
            Console.WriteLine("Contents of Country Data.txt = {0}", country);

        }
    }
    
}
