using System;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Net_1_256 = @"C:\Users\ODSTc\source\repos\GrimIron\CS\Assignment 1\Net_1_256.txt";
            int[] n1_256 = Net_file(256, Net_1_256);
            HeapSort_Decending(n1_256);
        }

        public static int[] Net_file(int array_length, string file_location)
        {
            int counter = 0;
            string line;
            int[] net_array = new int[array_length];
            StreamReader txt = new StreamReader(file_location);

            while ((line = txt.ReadLine()) != null)
            {
                int x = 0;                              //Sets X as a int with 0 as a default
                Int32.TryParse(line, out x);            //Checks to see if the value can be converted to a in, if yes then converts to a int
                net_array[counter] = x;                 //Sets the Array possition to the value of the counter and adds the value from the above line to the array
                Console.WriteLine(net_array[counter]);

                counter++;                              //Adds 1 to  the counter everytime it loops
            }

            txt.Close();
            return net_array;
        }

        public static void HeapSort_Decending(int[] heap)
        {
            //pre:0 <= n <= Heap.lenght
            //Post: values in Heap[0 ... n-1] are in accending order

            int heap_size = heap.Length;                   //sets value to the lengh of the array e.g. 256
            int i;
            for (i = (heap_size - 1) / 2; i >= 0; i--)     //sets i heap_size - 1 e.g. 255. Divides by 2 e.g. 127.5 Checks to see is its more than or equal to 0 if so then i - 1
            {
                Console.WriteLine(heap_size);
                Console.WriteLine(i);
                min_heapify(heap, heap_size, i);           //runs the min_heapify with the arguments (array of unstorted numbers), (heap_size e.g 256), (index e.g. 127) 
            }
            for (i = heap.Length - 1; i > 0; i--)          //sets i heap_size - 1 e.g. 255. Checks to see is its more than or equal to 0 if so then i - 1 e.g 254
            {
                int temp = heap[i];                        //sets temp to to the value in heap[i]
                heap[i] = heap[0];                         //set heap[i] to value heap[0]
                heap[0] = temp;                            //sets heap[0] to the value of temp
                Console.WriteLine("here");

                heap_size--;                               //reduces heap size by 1
                min_heapify(heap, heap_size, 0);
            }
        }

        private static void min_heapify(int[] heap, int heap_size, int index)
        {
            int left = (index + 1) * 2 - 1;                          //set value e.g. index = 127. (127 + 1) * 2 - 1 = 255
            int right = (index + 1) * 2;                             //set value e.g. index = 127. (127 + 1) * 2 = 256
            int largest = 0;

            if (left < heap_size && heap[left] > heap[index])       //checks to see if left is less than the heap_size AND that the value in heap[] in larger that heap[index] e.g.(255 < 256 && heap[left]255 > heap[index]127
            {
                largest = left;                                     //if the above is true largest is assigned the value of left e.g. 255
            }
            else
            {
                largest = index;                                    //if not largest is set as the index value e.g. 127
            }

            if (right < heap_size && heap[right] > heap[largest])  //checks to see if right is < heap_size AND that the value in heap[right] is larger than heap[largest]
            {
                largest = right;                                   //is the above is true then it is assigned the value right
            }

            if (largest != index)
            {
                int temp = heap[index];
                heap[index] = heap[largest];
                heap[largest] = temp;
                min_heapify(heap, heap_size, largest);
            }

        }
    }
}
