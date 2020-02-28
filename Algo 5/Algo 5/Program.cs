using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myint = genarate_randon_array(256, 0, 2048);

            Sort.mergeSort(myint, 0, myint.Length - 1);

            for (int i = 0; i < myint.Length; i++)
            {
                Console.Write(myint[i] + ",");
            }
            Console.ReadLine();
        }

        public static int[] genarate_randon_array(int size, int min, int max)
        {
            Random r = new Random();
            int[] myarr = new int[size];

            for (int i = 0; i < size; i++)
            {
                myarr[i] = r.Next(min, max + 1);
            }

            return myarr;
        }
    }
}
