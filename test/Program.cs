using System;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Net_1_256 = @"C:\Users\ODSTc\Source\Repos\GrimIron\CS\test\Net_1_256.txt";
            int[] n1_256 = Net_file(256, Net_1_256);
            QuickSort(n1_256);
            foreach (int i in n1_256)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
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


        public static void QuickSort(int[] data)
        {
            quickSort(data, 0, data.Length - 1);
        }

        private static int partition(int[] arr, int left, int right)
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

        private static void quickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                //pi is partitioning index, arr[pi] is now at right position
                int part = partition(arr, left, right);

                //recursively sort elements on ether side of the partition
                quickSort(arr, left, part - 1);
                quickSort(arr, part + 1, right);
            }
        }

    }
}
