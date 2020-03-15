using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Search
    {   //function for running a linear search
        public static void linear_search(int[] array_to_sort, int array_size, int key)
        {
            Console.WriteLine("searching...\n");

            bool success = false;

            //searches the array if it finds the value will print to console and change the value of success to true
            for (int i = 0; i < array_size; i++)
            {
                if (array_to_sort[i] == key)
                {
                    Console.WriteLine("The number is at position: " + i);
                    success = true;
                }
            }

            //if no values found, will run the fuction to find the closest value 
            if (success == false)
            {
                Console.WriteLine("Item Not found in array\n");
                linear_search_nearest(array_to_sort, array_size, key);
            }

            //prints complete when done 
            else
            {
                Console.WriteLine("----Search Complete----");
            }

        }
        //fuction for finding the value closet to what the users chose, called from linear_search()
        private static void linear_search_nearest(int[] array_to_sort, int array_size, int key)
        {
            for (int i = 0; i < array_size; i++)
            {
                //if the number is less then the key AND the next number is more than the key return the value
                if (array_to_sort[i] < key && array_to_sort[i + 1] > key)
                {
                    Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[i] + "  at possition " + i);
                }
            }

        }

        public static int binary_search(int[] array_to_sort, int left, int right, int key)
        {
            int mid = left + (right - left) / 2;

            if (right >= left)
            {
                if (array_to_sort[mid] == key)
                {
                    return mid;

                }
                if (array_to_sort[mid] > key)
                {
                    return binary_search(array_to_sort, left, mid - 1, key);
                }
                else
                {
                    return binary_search(array_to_sort, mid + 1, right, key);
                }
            }
            Console.WriteLine("Value not found, the nearest value is: \n" + array_to_sort[mid] + " at position " + mid);
            return -1;
        }

        public static int binary_search_more(int[] array_to_sort, int left, int right, int key)
        {
            int mid = left + (right - left) / 2;

            Console.WriteLine("r: " + right);
            Console.WriteLine("l: " + left);

            if (right >= left) // <======= HERE YOU FUCK!
            {
                //Console.WriteLine(mid);
                Console.ReadLine();
                if (array_to_sort[mid] == key)
                {
                    //Console.WriteLine("1: " + mid);
                    Console.WriteLine("The number was found at: " + array_to_sort[mid] + " at position " + mid);
                    //Console.WriteLine("2: " + mid);
                    //Console.WriteLine("3: " + (mid + 1) + " " + right);
                    return binary_search_more(array_to_sort, mid + 1, mid +2, key);
                }
                if (array_to_sort[mid] > key)
                {
                    Console.WriteLine("if 1 " + (mid - 1));
                    return binary_search_more(array_to_sort, left, mid - 1, key);
                }
                else
                {
                    Console.WriteLine("if 1 " + (mid + 1));
                    return binary_search_more(array_to_sort, mid + 1, right, key);
                }
            }
            Console.WriteLine("done");
            return -1;
        }

    }
}
