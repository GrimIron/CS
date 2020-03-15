using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Assignment_1
{
    public class Files
    {
        public static int[] Net_file(int array_length, string file_location)
        {
            //Console.WriteLine(file_location);
            int counter = 0;
            string line;
            int[] net_array = new int[array_length];
            StreamReader txt = new StreamReader(file_location);

            while ((line = txt.ReadLine()) != null)
            {
                int x = 0;                              //Sets X as a int with 0 as a default
                Int32.TryParse(line, out x);            //Checks to see if the value can be converted to a in, if yes then converts to a int
                net_array[counter] = x;                 //Sets the Array possition to the value of the counter and adds the value from the above line to the array
                //Console.WriteLine(net_array[counter]);

                counter++;                              //Adds 1 to  the counter everytime it loops
            }

            txt.Close();
            return net_array;




        }
    }
}
