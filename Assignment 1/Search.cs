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
    }
}
