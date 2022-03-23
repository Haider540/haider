using System;

namespace ConsoleAppProject.Helpers
{

    /// <summary>
    /// general purpose class containing methods
    /// that can be used by other console based classes in this app03.
    /// <author>
    /// Haider 2021
    /// </author>
    /// </summary>
    public static class ConsoleHelper
    {

        /// <summary>
        /// method shows a list of choices which are numbers 
        /// where users can select the choice. the choices start with 1.
        /// </summary>
        public static int SelectChoice(string[] choices)
        {
            // show all choices

            DisplayChoices(choices);

            // users choice

            int choiceNo = (int)InputNumber("\n enter your choice now > ",
                                            1, choices.Length);
            return choiceNo;
        }

        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.  {choice}");
            }
        }


        /// <summary>
        /// method will display a prompt to the user. return number as a double.
        /// </summary>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool isValid;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine(" invalid number lad!");
                }

            } while (!isValid);

            return number;
        }


        /// <summary>
        /// This method will prompt the user to enter a number
        /// between the min and max values includice.
        /// </summary>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid;
            double number;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number will be between {min} and {max}");
                }
                else isValid = true;

            } while (!isValid);

            return number;

        }

        /// <summary>
        /// short heading for the application
        /// and the name of the author and a prompt to
        /// inform the user which units are being converted.
        /// </summary>
        public static void OutputHeading(string heading)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("         BY HAIDER IMAM     ");
                Console.WriteLine("            22130768        ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            

            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        /// <summary>
        /// method will display a green title underlined
        /// with dashes.
        /// </summary>
        public static void OutputTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\n {title}");
            Console.Write(" ");

            for (int count = 0; count <= title.Length; count++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n");
            Console.ResetColor();
        }
    }
}