using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Search
    {   //function for running a linear search in accending order
        public static void linear_search_assend(int[] array_to_sort, int array_size, int key)
        {
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
                Console.WriteLine("----Item Not found in array----\n");
                linear_search_nearest_assend(array_to_sort, array_size, key);
            }

            //prints complete when done 
            else
            {
                Console.WriteLine("----Search Complete----");
            }

        }
        //fuction for finding the value closet to what the users chose, called from linear_search()
        private static void linear_search_nearest_assend(int[] array_to_sort, int array_size, int key)
        {
            Console.WriteLine(array_size);
            for (int i = 0; i < array_size; i++)
            {
                if (array_to_sort[i] < key && array_to_sort[i + 1] > key)
                {
                    Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[i] + " at possition " + i);
                    break;
                }
                else if (array_to_sort[0] > key)
                {
                    Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[i] + " at possition " + i);
                    break;
                }
                else if (array_to_sort[array_size] < key)
                {
                    Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[array_size] + " at possition " + array_size);
                    break;
                }
            }

        }

        //function for running a linear search in decsending order
        public static void linear_search_dec(int[] array_to_sort, int array_size, int key)
        {
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
                Console.WriteLine("----Item Not found in array----\n");
                linear_search_nearest_dec(array_to_sort, array_size, key);
            }

            //prints complete when done 
            else
            {
                Console.WriteLine("----Search Complete----");
            }

        }
        //fuction for finding the value closet to what the users chose, called from linear_search()
        private static void linear_search_nearest_dec(int[] array_to_sort, int array_size, int key)
        {
            Console.WriteLine("start " + array_size);
            for (int i = 0; i < array_size; i++)
            {
                if (array_to_sort[i] < key && array_to_sort[i + 1] < key)
                {
                    Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[i] + " at possition " + i);
                    break;
                }
                else if (key < array_to_sort[array_size])
                {

                    Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[array_size] + " at possition " + array_size);
                    break;
                }
                else if (array_to_sort[array_size] > key)
                {
                    Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[array_size] + " at possition " + array_size);
                    break;
                }
            }

        }


        //fuctions for running a binary search in accending order
        //calls the binary search accend function 
        public static void binary_search_assend(int[] array_to_sort, int key)
        { 
            int array_left = 0;                         //sets the left index
            int array_right = array_to_sort.Length - 1; //sets the right index 

            //runs the basic binary search, if the value doesnt exist in the array it will output the closest value
            int responce = binary_assend(array_to_sort, array_left, array_right, key);

            //checks to see if the value was found in the array, if its checks to see if there is any more values of the same number
            if (responce == -1)
            {
                Console.WriteLine("----Search Complete----");
            }
            else
            {
                binary_nearest_assend(array_to_sort, array_left, responce, key);
            }
        }
        //basic binary search that returns closest value if value not found
        private static int binary_assend(int[] array_to_sort, int left, int right, int key)
        {
            int mid = left + (right - left) / 2;

            if (right >= left)
            {
                //if item searching for the same and current index return the value
                if (array_to_sort[mid] == key)
                {
                    return mid;
                }
                //search to the left of mid
                if (array_to_sort[mid] > key)
                {
                    return binary_assend(array_to_sort, left, mid - 1, key);
                }
                //search to the right of mid
                else
                {
                    return binary_assend(array_to_sort, mid + 1, right, key);
                }
            }
            else if (key > array_to_sort[array_to_sort.Length - 1])
            {

                Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[array_to_sort.Length - 1] + " at possition " + (array_to_sort.Length - 1));
                return -1;

            }
            //if not found return its closest value
            Console.WriteLine("Value not found, the nearest value is: \n" + array_to_sort[mid] + " at position " + mid);
            return -1;
        }
        //second binary search that checks to see if the value appears multipul times, and if it does prints their index positions
        private static int binary_nearest_assend(int[] array_to_sort, int left, int right, int key)
        {
            int mid = left + (right - left) / 2;

            if (right >= left)
            {
                if (array_to_sort[mid] == key)
                {
                    Console.WriteLine("The number was found at position: " + mid);
                    return binary_nearest_assend(array_to_sort, mid + 1, mid +2, key);
                }
                //searches to the left of mid
                if (array_to_sort[mid] > key)
                {
                    return binary_nearest_assend(array_to_sort, left, mid - 1, key);
                }
                //searches to the right of mid
                else
                {
                    return binary_nearest_assend(array_to_sort, mid + 1, right, key);
                }
            }
            Console.WriteLine("----Search Complete----");
            return -1;
        }


        //functions for running a binary search in decending order
        //calls the binary search accend function 
        public static void binary_search_descend(int[] array_to_sort, int key)
        {
            Console.WriteLine("dec");
            int array_left = 0;
            int array_right = array_to_sort.Length - 1;

            int responce = binary_descend(array_to_sort, array_left, array_right, key);

            if (responce == -1)
            {
                Console.WriteLine("----Search Complete----");
            }
            else
            {
                binary_nearest_descend(array_to_sort, array_left, responce, key);
                //Search.binary_search_more(array_to_sort, responce + 1, array_right, choice);
            }
        }
        //basic binary search that returns closest value if value not found
        private static int binary_descend(int[] array_to_sort, int left, int right, int key)
        {
            int mid = left + (right - left) / 2;

            if (right >= left)
            {
                //if item searching for the same and current index return the value
                if (array_to_sort[mid] == key)
                {
                    return mid;
                }
                //searches to the left of mid
                if (array_to_sort[mid] < key)
                {
                    return binary_descend(array_to_sort, left, mid - 1, key);
                }
                //searches to the right of mid
                else
                {
                    return binary_descend(array_to_sort, mid + 1, right, key);
                }
            }
            else if (key < array_to_sort[array_to_sort.Length - 1])
            {

                Console.WriteLine("The number nearest to the value is:\n" + array_to_sort[array_to_sort.Length -1] + " at possition " + (array_to_sort.Length -1));
                return -1;

            }
            Console.WriteLine("Value not found, the nearest value is: \n" + array_to_sort[mid] + " at position " + mid);
            return -1;
        }
        //second binary search that checks to see if the value appears multipul times, and if it does prints their index positions
        private static int binary_nearest_descend(int[] array_to_sort, int left, int right, int key)
        {
            int mid = left + (right - left) / 2;

            if (right >= left)
            {
                //if item searching for the same and current index return the value
                if (array_to_sort[mid] == key)
                {
                    Console.WriteLine("The number was found at position: " + mid);
                    return binary_nearest_descend(array_to_sort, mid + 1, mid + 2, key);
                }
                //searches to the left of mid
                if (array_to_sort[mid] < key)
                {
                    return binary_nearest_descend(array_to_sort, left, mid - 1, key);
                }
                //searches to the right of mid
                else
                {
                    return binary_nearest_descend(array_to_sort, mid + 1, right, key);
                }
            }
            Console.WriteLine("----Search Complete----");
            return -1;
        }
    }
}
