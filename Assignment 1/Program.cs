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

            int sort_type = user_sort_choice();                             //asks the user the choose a sort type          
            int accend_decsend = user_accend_or_descend();                  //asks the user if they want the array sorting in accending or decending order

            int[] sorted_array = sort(array, sort_type, accend_decsend);    //sorts the array based on the choices the user made

            print_values(sorted_array, sorted_array.Length);                //prints the every 10th value for 256 arrays and every 50th value of 2048 arrays to console

            Console.WriteLine("\n");

            int search_type = user_search_choice();                         //asks the users what search fuction they would like to use to search the array

            search(sorted_array, search_type, accend_decsend);

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
                Console.WriteLine("Enter 4 for Net_1_256 and Net_3_256 merged");
                Console.WriteLine("Enter 5 for Net_1_2048");
                Console.WriteLine("Enter 6 for Net_2_2048");
                Console.WriteLine("Enter 7 for Net_3_2048");
                Console.WriteLine("Enter 8 for Net_1_256 and Net_3_256 merged");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 8);

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
            else if (choice == 3)
            {
                int[] n3_256 = Files.Net_file(256, Net_3_256);
                return n3_256;
            }
            else if (choice == 4)
            {
                int[] n1_256 = Files.Net_file(256, Net_1_256);
                int[] n3_256 = Files.Net_file(256, Net_3_256);
                int[] n1_n3_256 = n1_256.Concat(n3_256).ToArray();

                return n1_n3_256;
            }
            else if (choice == 5)
            {
                int[] n1_2048 = Files.Net_file(2048, Net_1_2048);
                return n1_2048;
            }
            else if (choice == 6)
            {
                int[] n2_2048 = Files.Net_file(2048, Net_2_2048);
                return n2_2048;
            }
            else if (choice == 7)
            {
                int[] n3_2048 = Files.Net_file(2048, Net_3_2048);
                return n3_2048;
            }
            else
            {
                int[] n1_2048 = Files.Net_file(256, Net_1_256);
                int[] n3_2048 = Files.Net_file(256, Net_3_256);
                int[] n1_n3_256 = n1_2048.Concat(n3_2048).ToArray();

                return n1_n3_256;
            }
          

        }

        private static int user_sort_choice()
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
            return choice;
        }

        private static int user_search_choice()
        {
            int choice;
            do
            {
                Console.WriteLine("What type of sort do you want to use:");
                Console.WriteLine("Enter 1 for Linear search");
                Console.WriteLine("Enter 2 for Binary search");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2);
            return choice;
        }

        private static int user_accend_or_descend()
        {
            int choice;
            do
            {
                Console.WriteLine("Do you want to sort in accending or descending order:");
                Console.WriteLine("Enter 1 for accending");
                Console.WriteLine("Enter 2 for descending");
            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2);

            return choice;
        }

        private static int[] sort(int[] array, int choice, int accend_decsend)
        {
            if (choice == 1)
            {
                Console.WriteLine("You chose Heap sort!\n");
                if (accend_decsend == 1)
                {
                    Sort.HeapSort_Assending(array);
                    return array;
                }
                else
                {
                    Sort.Heapsort_Descend(array);
                    return array;
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose Quick sort!\n");
                if (accend_decsend == 1)
                {
                    Sort.QuickSort_Accending(array);
                    return array;
                }
                else
                {
                    Sort.QuickSort_Descending(array);
                    return array;
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose Insertion sort!\n");
                if (accend_decsend == 1)
                {
                    Sort.Insertion_Sort_Assend(array);
                    return array;
                }
                else
                {
                    Sort.Insertion_Sort_Descend(array);
                    return array;
                }
            }
            else
            {
                Console.WriteLine("You chose Bubble sort!\n");
                if (accend_decsend == 1)
                {
                    Sort.Bubble_Sort_Assend(array);
                    return array;
                }
                else
                {
                    Sort.Bubble_Sort_Descend(array);
                    return array;
                }
            }
        }

        private static void search(int[] array, int search_type, int accend_decsend)
        {
            int locate;
            do
            {
                Console.WriteLine("What number do you want to locate: ");
            }
            while (!int.TryParse(Console.ReadLine(), out locate));

            if (search_type == 1)
            {
                Console.WriteLine("Linear Search: ");
                if (accend_decsend == 1)
                {
                    Search.linear_search_assend(array, array.Length - 1, locate);
                }
                else
                {
                    Search.linear_search_dec(array, array.Length - 1, locate);
                }
            }
            else
            {
                Console.WriteLine("Binary Search: ");
                if (accend_decsend == 1)
                {
                    Search.binary_search_assend(array, locate);
                }
                else
                {
                    Search.binary_search_descend(array, locate);
                }
            }
        }

        private static void print_values(int[] array, int element)
        {
            int counter = 0;
            if (element <= 512)
            {
                Console.WriteLine("Every 10th value:");
                foreach (int a in array)
                {
                    if ((counter % 10) == 0)
                    {
                        Console.Write("{0} ", array[counter]);
                    }
                    counter++;
                }
            }
            else
            {
                Console.WriteLine("Every 50th value:");
                foreach (int a in array)
                {
                    if ((counter % 50) == 0)
                    {
                        Console.Write("{0} ", array[counter]);
                    }
                    counter++;
                }
            }
        }

        /*private static void binary_search(int[] array_to_sort)
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

                Search.binary_search_more(array_to_sort, array_left, responce, choice);
                //Search.binary_search_more(array_to_sort, responce + 1, array_right, choice);
            }
        }*/
    }
}
