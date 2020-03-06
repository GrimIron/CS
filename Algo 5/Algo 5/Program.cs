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
           int[] myArray_1 = new int[] { -45, -91, -81, 65, 39, -37, 90, -94 };

            Sort.Quick_Sort(myArray_1, myArray_1[0], myArray_1[7]);
        }
        /*static void Main(string[] args)
        {
            int[] myint = genarate_randon_array(256, 0, 2048);
            
            //sort array
            Sort.mergeSort(myint, 0, myint.Length - 1);

            //display the array, easier for testing search algo's
            for (int i = 0; i < myint.Length; i++)
            {
                Console.Write(myint[i] + ",");
            }

            //preform linear search, put result in index
            int index = Search.linear_search(myint, myint.Length, 2020);

            //tell user if value was in the array
            if (index != -1)
            {
                Console.WriteLine("Value found at position {0}", index);
            }
            else
            {
                Console.WriteLine("Value does not exist in search space");
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
        }*/
    }
}
