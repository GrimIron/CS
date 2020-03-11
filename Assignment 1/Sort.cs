using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Sort
    {
        private static void Merge(int[] arr, int left, int midpoint, int right)
        {
            int i, j, k;
            int n1 = midpoint - left + 1;
            int n2 = right - midpoint;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = arr[left + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[midpoint + 1 + j];
            i = 0;
            j = 0;
            k = left;
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

        public static void MergeSort(int[] array_to_sort, int left, int right)
        {
            if (left < right)
            {
                int mid_point = left + (right - left) / 2;


                MergeSort(array_to_sort, left, mid_point);
                MergeSort(array_to_sort, mid_point + 1, right);

                Merge(array_to_sort, left, mid_point, right);
            }
        }

        public static void QuickSort(int[] data)
        {
            //pre: 0 <= n <= data.length
            //post: values in data[0 ... n-1] are in accending order

            Quick_Sort(data, 0, data.Length - 1);
        }

        private static void Quick_Sort(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;

            i = left;                           //left most value in the array[0]
            j = right;                          //right most value in the array[255]
            pivot = data[(left + right) / 2];   //adds the left most value to the right then divides by 2 to get the pivot value 

            do
            {
                while ((data[i] < pivot) && (i < right)) i++; //while left most value is less than pivot AND i is less than right: i + 1
                while ((pivot < data[j]) && (j > left)) j--;  //while pivot is less than rightn most value AND j is more than than right: j - 1

                if (i <= j)                     //If i is less than or equal to j the values will swap over with i becoming j the right value, and j becoming i the left value
                {
                    temp = data[i];             //Temp is used as to save the value of i before it can be assigned to j
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            }while (i <= j);

            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }

        public static void HeapSort_Assending(int[] heap)
        {
            //pre:0 <= n <= Heap.lenght
            //Post: values in Heap[0 ... n-1] are in accending order

            int heap_size = heap.Length;
            int i;
            for (i = (heap_size - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(heap, heap_size, i);
            }
            for (i = heap.Length -1; i> 0; i--)
            {
                int temp = heap[i];
                heap[i] = heap[0];
                heap[0] = temp;

                heap_size--;
                Max_Heapify(heap, heap_size, 0);
            }
        }

        private static void Max_Heapify(int[] heap, int heap_size, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left <heap_size && heap[right]> heap[largest])
            {
                largest = left;
            }
            else
            {
                largest = index;
            }

            if (right < heap_size && heap[right] > heap[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                int temp = heap[index];
                heap[index] = heap[largest];
                heap[largest] = temp;
                Max_Heapify(heap, heap_size, largest);
            }

        }

        public static void HeapSort_Decending(int[] heap)
        {
            //pre:0 <= n <= Heap.lenght
            //Post: values in Heap[0 ... n-1] are in accending order

            int heap_size = heap.Length;
            int i;
            for (i = (heap_size - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(heap, heap_size, i);
            }
            for (i = heap.Length - 1; i > 0; i--)
            {
                int temp = heap[i];
                heap[i] = heap[0];
                heap[0] = temp;

                heap_size--;
                Max_Heapify(heap, heap_size, 0);
            }
        }

        private static void Min_Heapify(int[] heap, int heap_size, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heap_size && heap[right] > heap[largest])
            {
                largest = left;
            }
            else
            {
                largest = index;
            }

            if (right < heap_size && heap[right] > heap[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                int temp = heap[index];
                heap[index] = heap[largest];
                heap[largest] = temp;
                Min_Heapify(heap, heap_size, largest);
            }

        }
    }
}
