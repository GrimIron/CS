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
            int[] array = net_choice();

            sort_choice(array);

            Console.WriteLine("\n");

            search_choice(array);

            Console.ReadLine();

        }

        private static int[] net_choice()
        {
            string Net_1_256 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_1_256.txt";
            string Net_1_2048 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_1_2048.txt";
            string Net_2_256 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_2_256.txt";
            string Net_2_2048 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_2_2048.txt";
            string Net_3_256 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_3_256.txt";
            string Net_3_2048 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_3_2048.txt";

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
                int[] n1_256 = Files.Net_file(256, Net_1_256);
                return n1_256;
            }
            else if (choice == 2)
            {
                int[] n2_256 = Files.Net_file(256, Net_2_256);
                return n2_256;
            }
            else
            {
                int[] n3_256 = Files.Net_file(256, Net_3_256);
                return n3_256;
            }
        }

        private static void sort_choice(int[] array)
        {
            int choice;
            do
            {
                Console.WriteLine("What type of sort do you want to use:");
                Console.WriteLine("Enter 1 for Heap sort");
                Console.WriteLine("Enter 2 for Quick sort");
                Console.WriteLine("Enter 3 for Insertion Sort");
                Console.WriteLine("Enter 4 for Bubble Sort");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 4);

            if (choice == 1)
            {
                Heap_Sort(array);
            }
            else if (choice == 2)
            {
                Quick_Sort(array);
            }
            else if (choice == 3)
            {
               
            }
            else
            {

            }
        }

        private static void search_choice(int[] array)
        {
            int choice;
            do
            {
                Console.WriteLine("What type of sort do you want to use:");
                Console.WriteLine("Enter 1 for Linear search");
                Console.WriteLine("Enter 2 for Binary search");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2);

            if (choice == 1)
            {
                linear_search(array);
            }
            else
            {
                binary_search(array);
            }
    }

        private static void Quick_Sort(int[] array)
        {
            Console.WriteLine("You chose Quick sort!\n");
            int choice;
            do
            {
                Console.WriteLine("Do you want to sort in accending or descending order:");
                Console.WriteLine("Enter 1 for accending");
                Console.WriteLine("Enter 2 for descending");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2);

            if (choice == 1)
            {
                Sort.QuickSort_Accending(array);
                Console.WriteLine("Every 10th value in accending order");
            }
            else
            {
                Sort.QuickSort_Descending(array);
                Console.WriteLine("Every 10th value in descending order");
            }

            int counter = 0;
            foreach (int a in array)
            {
                //Console.WriteLine(a);
                if ((counter % 10) == 0)
                {
                    Console.Write("{0} ", array[counter]);
                }
                counter++;
            }
        }

        private static void Heap_Sort(int[] array)
        {
            Console.WriteLine("You chose Heap sort!\n");
            int choice;
            do
            {
                Console.WriteLine("Do you want to sort in accending or descending order:");
                Console.WriteLine("Enter 1 for accending");
                Console.WriteLine("Enter 2 for descending");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2);

            if (choice == 1)
            {
                Sort.HeapSort_Assending(array);
                Console.WriteLine("Every 10th value in accending order:");
            }
            else
            {
                Sort.Heapsort_Decending(array);
                Console.WriteLine("Every 10th value in descending order:");
            }

            int counter = 0;
            foreach (int a in array)
            {
                if ((counter % 10) == 0)
                {
                    Console.Write("{0} ", array[counter]);
                }
                counter++;
            }
        }

        private static void linear_search(int[] array)
        {
            int choice;
            do
            {
                Console.WriteLine("What number do you want to find:");
            }
            while (!int.TryParse(Console.ReadLine(), out choice));

            int array_size = array.Length;
            Search.linear_search(array, array_size, choice);
        }

        private static void binary_search(int[] array_to_sort)
        {
            int array_left = 0;
            int array_right = array_to_sort.Length - 1;
            int choice;
            do
            {
                Console.WriteLine("What number do you want to find:");
            }
            while (!int.TryParse(Console.ReadLine(), out choice));

            int responce = Search.binary_search(array_to_sort, array_left, array_right, choice);

            if (responce == -1)
            {
                Console.WriteLine("----Search Complete----");
            }
            else
            {
                //Console.WriteLine("The number was found at: " + array_to_sort[responce] + " at position " + responce);
                //Console.WriteLine(responce);
                //Console.WriteLine(responce - 1);
                //Console.WriteLine(responce + 1);
                //Console.WriteLine(array_left);
                //Console.WriteLine(array_right);
                //Console.ReadLine();

                Search.binary_search_more(array_to_sort, array_left, responce, choice);
                //Search.binary_search_more(array_to_sort, responce + 1, array_right, choice);
            }
        }
    }
}
