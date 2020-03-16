using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Sort
    {
        //Quick sort algorithms 
        //calls quick sort in accending order
        public static void QuickSort_Accending(int[] data)
        {
            quicksort_accend(data, 0, data.Length - 1);
        }
        //creates a partition value and sorts either side of it via recursion
        private static void quicksort_accend(int[] array_to_sort, int left, int right)
        {
            if (left < right)
            {
                //part is partitioning index, array_to_sort[part] is now at right position
                int part = partition_accend(array_to_sort, left, right);

                //recursively sort elements on ether side of the partition
                quicksort_accend(array_to_sort, left, part - 1);
                quicksort_accend(array_to_sort, part + 1, right);
            }
        }
        //checks the values based on the pivot, and places in assending order
        private static int partition_accend(int[] array_to_sort, int left, int right)
        {
            int pivot = array_to_sort[right];   //sets the pivot to the right most value
            int index = (left - 1);             //sets to the smallest value

            for (int j = left; j < right; j++)
            {
                //if current element is smaller than the pivot 
                if (array_to_sort[j] < pivot)
                {
                    index++;
                    //swap array_to_sort[index] and array_to_sort[j] 
                    int temp = array_to_sort[index];
                    array_to_sort[index] = array_to_sort[j];
                    array_to_sort[j] = temp;
                }
            }
            //swap array_to_sort[index + 1] and array_to_sort[right] or pivot
            int temp1 = array_to_sort[index + 1];
            array_to_sort[index + 1] = array_to_sort[right];
            array_to_sort[right] = temp1;
            return index + 1;
        }

        //calls quick sort in descending order
        public static void QuickSort_Descending(int[] data)
        {
            quickSort_descend(data, 0, data.Length - 1);
        }
        //creates a partition value and sorts either side of it via recursion
        private static void quickSort_descend(int[] array_to_sort, int left, int right)
        {
            if (left < right)
            {
                //part is partitioning index, array_to_sort[part] is now at right position
                int part = partition_descend(array_to_sort, left, right);

                //recursively sort elements on ether side of the partition
                quickSort_descend(array_to_sort, left, part - 1);
                quickSort_descend(array_to_sort, part + 1, right);
            }
        }
        //checks the values based on the pivot, and places in descending order
        private static int partition_descend(int[] array_to_sort, int left, int right)
        {
            int pivot = array_to_sort[right];   //sets the pivot to the right most value
            int index = (left - 1);             //sets to the smallest value

            for (int j = left; j < right; j++)
            {
                //if current element is smaller than the pivot 
                if (array_to_sort[j] > pivot)
                {
                    index++;
                    //swap array_to_sort[index] and array_to_sort[j]  
                    int temp = array_to_sort[index];
                    array_to_sort[index] = array_to_sort[j];
                    array_to_sort[j] = temp;
                }
            }

            //swap array_to_sort[index + 1] and array_to_sort[right]
            int temp1 = array_to_sort[index + 1];
            array_to_sort[index + 1] = array_to_sort[right];
            array_to_sort[right] = temp1;

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
            for (i = array_to_sort.Length - 1; i > 0; i--)
            {
                //moves the current index to the end
                int temp = array_to_sort[i];
                array_to_sort[i] = array_to_sort[0];
                array_to_sort[0] = temp;

                heap_size--;
                Max_Heapify(array_to_sort, heap_size, 0);
            }
        }
        //creates the heap
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

        public static void Heapsort_Descend(int[] array_to_sort)
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
        //creates the heap
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


        //Bubble sort algorithms
        public static void Bubble_Sort_Assend(int[] array_to_sort)
        {
            int i;
            int j;
            int temp;
            int lenght = array_to_sort.Length;
            bool swapped;
            for (i = 0; i < lenght - 1; i++)
            {
                swapped = false;
                for (j = 0; j < lenght - i - 1; j++)
                {
                    if (array_to_sort[j] > array_to_sort[j + 1])
                    {
                        //swap array_to_sort[j] and array_to_sort[j+1] 
                        temp = array_to_sort[j];
                        array_to_sort[j] = array_to_sort[j + 1];
                        array_to_sort[j + 1] = temp;
                        swapped = true;
                    }
                }

                //no two elements were swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        public static void Bubble_Sort_Descend(int[] array_to_sort)
        {
            int i;
            int j;
            int temp;
            int lenght = array_to_sort.Length;
            bool swapped;
            for (i = 0; i < lenght - 1; i++)
            {
                swapped = false;
                for (j = 0; j < lenght - i - 1; j++)
                {
                    if (array_to_sort[j] < array_to_sort[j + 1])
                    {
                        //swap array_to_sort[j] and array_to_sort[j+1] 
                        temp = array_to_sort[j];
                        array_to_sort[j] = array_to_sort[j + 1];
                        array_to_sort[j + 1] = temp;
                        swapped = true;
                    }
                }

                //no two elements were swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }


        //Insertion Sort algorithms
        public static void Insertion_Sort_Assend(int[] array_to_sort)
        {
            int length = array_to_sort.Length;
            for (int i = 1; i < length; ++i)
            {
                int key = array_to_sort[i];
                int j = i - 1;

                //Move elements of array_to_sort[0 to i-1] that are greater than the key to one position ahead of their current position 
                while (j >= 0 && array_to_sort[j] > key)
                {
                    array_to_sort[j + 1] = array_to_sort[j];
                    j = j - 1;
                }
                array_to_sort[j + 1] = key;
            }
        }

        public static void Insertion_Sort_Descend(int[] array_to_sort)
        {
            int length = array_to_sort.Length;
            for (int i = 1; i < length; ++i)
            {
                int key = array_to_sort[i];
                int j = i - 1;

                //Move elements of array_to_sort[0 to i-1] that are greater than the key to one position behind their current position 
                while (j >= 0 && array_to_sort[j] < key)
                {
                    array_to_sort[j + 1] = array_to_sort[j];
                    j = j - 1;
                }
                array_to_sort[j + 1] = key;
            }
        }
    }
}
