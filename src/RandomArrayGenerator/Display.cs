using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class Printer
    {
        public static void printArray(string prefix, IEnumerable<int> items, int columns)
        {
            // for the example logic, we dont need a large amount of output and dont need to handle it into columns
            if (items.Count() <= columns)
            {
                // just display in one line
                Console.WriteLine(prefix + " " + string.Join(" ", items));
            }
            // for an array with a size of 10,000 it is probably helpful to organize the output into columns
            else
            {
                int count = 0;

                // output the provided prefix
                Console.WriteLine(prefix);

                // loop through each value in the array
                foreach (var item in items)
                {
                    // write each item, padding for the maximum column width
                    Console.Write(item.ToString().PadLeft(6));
                    count++;

                    // when multiple of provided variable columns, create a line break
                    if (count % columns == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
