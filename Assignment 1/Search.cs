using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Search
    {
        public static int linear_search(int[] array_to_sort, int array_size, int key)
        {
            for (int i = 0; i < array_size; i++)
            {
                if (array_to_sort[i] == key)
                    return i;
            }
            // Item not found in the array
            return -1;
        }

        static int binarySearch(int[] array_to_sort, int left, int right, int key)
        {
            if (right >= l)
            {
                int mid = left + (right - l) / 2;

                if (arr[mid] == key)                            //Checks to see if the middle element is the key if it is it will return
                {
                    return mid;
                }

                if (arr[mid] > key)
                {
                    return binarySearch(array_to_sort, left, mid - 1, key);
                }

                else
                {
                    return binarySearch(arr, mid + 1, r, x);
                }
               
            }

            return -1;
        }
    }
}
