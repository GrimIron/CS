using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Sort
    {
        //Merge sort algorithms 
        private static void Merge_Accending(int[] array_to_sort, int left, int midpoint, int right)
        {
            int i, j, k;
            int n1 = midpoint - left + 1;
            int n2 = right - midpoint;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = array_to_sort[left + i];
            for (j = 0; j < n2; j++)
                R[j] = array_to_sort[midpoint + 1 + j];
            i = 0;
            j = 0;
            k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array_to_sort[k] = L[i];
                    i++;
                }
                else
                {
                    array_to_sort[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array_to_sort[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array_to_sort[k] = R[j];
                j++;
                k++;
            }
        }
        //recersivly calls itself until the size of the array_to_sort becomes one
        public static void MergeSort_Accending(int[] array_to_sort, int left, int right)
        {   
            if (left < right)
            {
                int mid_point = left + (right - left) / 2;                  //e.g. 0 + (255 - 0) / 2 =

                MergeSort_Accending(array_to_sort, left, mid_point);         
                MergeSort_Accending(array_to_sort, mid_point + 1, right);

                Merge_Accending(array_to_sort, left, mid_point, right);
            }
        }


        //Quick sort algorithms 
        public static void QuickSort_Accending(int[] data)
        {
            quicksort_accend(data, 0, data.Length - 1);
        }

        private static void quicksort_accend(int[] arr, int left, int right)
        {
            if (left < right)
            {
                //pi is partitioning index, arr[pi] is now at right position
                int part = partition_accend(arr, left, right);

                //recursively sort elements on ether side of the partition
                quicksort_accend(arr, left, part - 1);
                quicksort_accend(arr, part + 1, right);
            }
        }

        private static int partition_accend(int[] arr, int left, int right)
        {
            int pivot = arr[right];   //sets the pivot to the right most value
            int index = (left - 1);   //sets to the smallest value

            for (int j = left; j < right; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    index++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[index];
                    arr[index] = arr[j];
                    arr[j] = temp;
                }
            }

            //swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[index + 1];
            arr[index + 1] = arr[right];
            arr[right] = temp1;

            return index + 1;
        }


        public static void QuickSort_Descending(int[] data)
        {
            quickSort_descend(data, 0, data.Length - 1);
        }

        private static void quickSort_descend(int[] arr, int left, int right)
        {
            if (left < right)
            {
                //pi is partitioning index, arr[pi] is now at right position
                int part = partition_descend(arr, left, right);

                //recursively sort elements on ether side of the partition
                quickSort_descend(arr, left, part - 1);
                quickSort_descend(arr, part + 1, right);
            }
        }

        private static int partition_descend(int[] arr, int left, int right)
        {
            int pivot = arr[right];   //sets the pivot to the right most value
            int index = (left - 1);   //sets to the smallest value

            for (int j = left; j < right; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] > pivot)
                {
                    index++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[index];
                    arr[index] = arr[j];
                    arr[j] = temp;
                }
            }

            //swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[index + 1];
            arr[index + 1] = arr[right];
            arr[right] = temp1;

            return index + 1;
        }


        //Heap Sort algorithms
        public static void HeapSort_Assending(int[] array_to_sort)
        {
            int heap_size = array_to_sort.Length;       //sets value to the lengh of the array e.g. 256
            int i;                                      //current index

            //Builds the heap (rearranges the array), before the sorting begins
            for (i = (heap_size - 1) / 2; i >= 0; i--)  
            {
                Max_Heapify(array_to_sort, heap_size, i);     
            }

            //extracts a element one by one
            for (i = array_to_sort.Length -1; i> 0; i--)
            {
                //moves the current index to the end
                int temp = array_to_sort[i];
                array_to_sort[i] = array_to_sort[0];
                array_to_sort[0] = temp;

                heap_size--;
                Max_Heapify(array_to_sort, heap_size, 0);
            }
        }

        private static void Max_Heapify(int[] heap, int heap_size, int index)
        {   
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = index;                 //sets the largest to the current index

            //Checks to see if the left child is larger than the index, if so then largest becomes the value left 
            if (left < heap_size && heap[left] > heap[largest])
            {
                largest = left;
            }
            //Checks to see is the right child is larger than the largest so far, is so them largest becames the value of right
            if (right < heap_size && heap[right] > heap[largest])
            {
                largest = right;
            }

            //Checks to see if the largest is equal to the index, if not they swap positions and recurses
            if (largest != index)
            {
                int temp = heap[index];
                heap[index] = heap[largest];
                heap[largest] = temp;

                //recurses the subtree
                Max_Heapify(heap, heap_size, largest);
            }

        }

        public static void Heapsort_Decending(int[] array_to_sort)
        {
            int heap_size = array_to_sort.Length;     //sets value to the lengh of the array e.g. 256
            int i;                                    //current index

            //builds the heap (rearranges the array), before the sorting begins
            for (i = (heap_size - 1) / 2; i >= 0; i--)     
            {
                Min_Heapify(array_to_sort, heap_size, i);          
            }

            //extracts a element one by one
            for (i = heap_size - 1; i > 0; i--)          
            {
                //moves the current index to the end
                int temp = array_to_sort[i];
                array_to_sort[i] = array_to_sort[0];
                array_to_sort[0] = temp;                            

                heap_size--;                               
                Min_Heapify(array_to_sort, heap_size, 0);
            }
        }

        private static void Min_Heapify(int[] heap, int heap_size, int index)
        {
            int left = (2 * index) + 1;                              
            int right = (2 * index) + 2;                             
            int smallest = index;           //set smallest as the current index

            //checks to see if the left child is smaller than the index, if it is smallest is set the value of left 
            if (left < heap_size && heap[left] < heap[smallest])     
            {
                smallest = left;                                     
            }

            //checks to see if the right child is the smallest so far, is it is smallest is set to the value of right
            if (right < heap_size && heap[right] < heap[smallest])   
            {
                smallest = right;                                   
            }

            //is the smallest is not equal to the index, if not they swap positons and recurses.
            if (smallest != index)                                
            {
                int temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;
                Min_Heapify(heap, heap_size, smallest);
            }

        }
    }
}
