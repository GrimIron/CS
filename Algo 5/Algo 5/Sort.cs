using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_5
{
    class Sort
    {
        private static void merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];
            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;


                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }

        public static void QuickSort(int[] data)
        {
            //pre: 0 <= n <= data.length
            //post: values in data[0 ... n-1] are in accending order

            Quick_Sort(data, 0, data.Length - 1);
        }

        public static void Quick_Sort(int[] data, int left, int right)
        {
            int counter = 0;
            int i, j;
            int pivot, temp;

            i = left;                           //left most value in the array
            j = right;                          //right most value in the array
            pivot = data[(left + right) / 2];   //adds the left most value to the right then divides by 2 to get the pivot value 

            do
            {
                while ((data[i] < pivot) && (i < right)) i++; //while left most value is less than pivot AND i is less than right: i + 1
                while ((pivot < data[j]) && (j < left)) j--;  //while pivot is less than rightn most value AND j is less than right: j - 1

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            }while (i <= j);

            Console.WriteLine(counter);

            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }
    }
}
