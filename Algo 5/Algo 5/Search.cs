using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_5
{
    class Search
    {
        public static int linear_search(int[] arr, int arr_size, int key)
        {
            for (int i = 0; i < arr_size; i++)
            {
                if (arr[i] == key)
                    return i;
            }
            // Item not found in the array
            return -1;
        }
    }
}
