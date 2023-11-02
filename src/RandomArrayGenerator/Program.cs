using System;
using MenuOptions;

class Program
{
    /*
     * THIS IS THE MAIN PROGRAM WHERE THE APPLICATION ORIGINATES
     */
    static void Main()
    {
        // Exit Condition
        bool exitCondition = false;

        // Program Loop
        while (exitCondition != true)
        {
            // Menu Header Display
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, please select an option below by typing the associated number!");
            Console.ForegroundColor = ConsoleColor.White;

            // Menu Options Display
            Console.WriteLine("1) Generate List");
            Console.WriteLine("2) Explain Program Logic with Example");
            Console.WriteLine("3) Exit Program");
            Console.WriteLine();

            // User Entry Prompt
            Console.Write("Selection: ");

            
            try
            {
                int menuOption = int.Parse(Console.ReadLine());
                switch (menuOption)
                {
                    case 1:
                        // if user selects 1, execute application
                        Console.WriteLine("You selected option 1\n");
                        Option.randomArrayGeneration(10000);
                        break;
                    case 2:
                        // if user selects 2, explain application
                        Console.WriteLine("You selected option 2\n");
                        Option.explanation(3);
                        break;
                    case 3:
                        // if user selects 3, exit application
                        exitCondition = true;
                        break;
                    default:
                        // if user selects any number not listed, inform them it is not an option
                        Console.WriteLine(menuOption + " is not a listed option\n");
                        break;
                }
            }

            // if the value entered is not an integer, catch error and inform user its invalid
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured: " + ex.Message + "\n");
            }

        }

    }

}