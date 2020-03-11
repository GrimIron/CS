using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = net_256_choice();

            Quicksort_test(array);

            Console.ReadLine();

        }

        private static int[] net_256_choice()
        {
            string Net_1_256 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_1_256.txt";
            string Net_1_2048 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_1_2048.txt";
            string Net_2_256 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_2_256.txt";
            string Net_2_2048 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_2_2048.txt";
            string Net_3_256 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_3_256.txt";
            string Net_3_2048 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_3_2048.txt";

            int[] n1_256 = Files.Net_file(256, Net_1_256);
            int[] n2_256 = Files.Net_file(256, Net_2_256);
            int[] n3_256 = Files.Net_file(256, Net_3_256);

            int choice;

            do
            {
                Console.WriteLine("What array do you want to analysed?:");
                Console.WriteLine("Enter 1 for Net_1_256");
                Console.WriteLine("Enter 2 for Net_2_256");
                Console.WriteLine("Enter 3 for Net_3_256");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 3);

            if (choice == 1)
            {
                return n1_256;
            }
            else if (choice == 2)
            {
                return n2_256;
            }
            else
            {
                return n3_256;
            }
        }

        private static void Quicksort_test(int[] Array_to_sort)
        {
            int counter = 0;

            Sort.QuickSort(Array_to_sort);

            foreach (int a in Array_to_sort)
            {
                if ((counter % 10) == 0)
                {
                    Console.Write("{0} ", Array_to_sort[counter]);
                }
                counter++;
            }

            counter = 0;

            Console.ReadLine();
        }

        private static void Mergesort_test(int[] Array_to_sort)
        {

        }
        private static void Mergesort()
        {
            int[] myint = genarate_randon_array(256, 0, 2048);

            //sort array
            Sort.MergeSort(myint, 0, myint.Length - 1);

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

        private static int[] genarate_randon_array(int size, int min, int max)
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
