using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Haider Imam
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("      covert miles to feet       ");
            Console.WriteLine("         by Haider Imam          ");
            Console.WriteLine("-------------------------------\n");

        }

        /// <summary>
        /// prompt the user to enter the distance in miles
        /// Input the miles as a two digit number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + "feet!");
        }

    }
}
