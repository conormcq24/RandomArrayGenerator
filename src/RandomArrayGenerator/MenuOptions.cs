using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Display;

namespace MenuOptions
{
    public class Option
    {
        public static void randomArrayGeneration(int listSize)
        {
            // generate list of 10 numbers 
            List<int> numbersList = new List<int>();
            for (int i = 0; i < listSize; i++)
            {
                numbersList.Add(i + 1);
            }

            // create empty array with size of 10
            int[] randomList = new int[listSize];

            Random random = new Random();

            // loop 10 times
            for (int j = 0; j < listSize; j++)
            {
                // each loop pick a random index, between 0 and the remaining list size
                int rng = random.Next(0, numbersList.Count);

                // use that index to pull a value from the ordered list, and insert into the random list
                randomList[j] = numbersList[rng];

                // remove the index on the ordered list, so that we repeat no random numbers
                numbersList.RemoveAt(rng);
            }

            // display the random list
            Printer.printArray("Random Number List: ", randomList, 10);
            Console.WriteLine("\n");
        }

        public static void explanation(int listSize)
        {
            // generate list of 3 numbers 
            List<int> numbersList = new List<int>();
            for (int i = 0; i < listSize; i++)
            {
                numbersList.Add(i + 1);
            }

            Console.WriteLine("The program creates an ordered list like so:");

            Printer.printArray("Value: ", numbersList, 3);
            Printer.printArray("Index: ", Enumerable.Range(0, numbersList.Count).ToArray(), 3);

            Random random = new Random();
            int rng = random.Next(0, numbersList.Count);

            Console.WriteLine("After that we take a random index, in this case: " + rng + " (Within the ordered lists size)");
            Console.WriteLine("then we get the value assigned to that index (" + numbersList[rng] + "), and add it to a new array ");
            Console.WriteLine("we then remove that index (" + rng + ") from the list \n");


            int[] randomList = new int[10];

            randomList[0] = numbersList[rng];
            numbersList.RemoveAt(rng);

            Console.WriteLine("This leaves us with a numbered list of size ("+ numbersList.Count +"), with the specified value being removed");

            Printer.printArray("Value: ", numbersList, 3);
            Printer.printArray("Index: ", Enumerable.Range(0, numbersList.Count).ToArray(), 3);


            Console.WriteLine("\nThis also leaves us with a new array, containing the first random number selected (" + randomList[0] + ")");
            Console.WriteLine("at its start. this process is repeated until the numbered list is empty, and the random list is full");
            Console.WriteLine("and ensures that we only have to generate a random number, once per element in the list\n");
        }
    }
}
