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
        public const int FEET_IN_MILES = 5280;

        public const double MILES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";
       
        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public double METRES_IN_MILES { get; private set; }

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }



        ///<summary>
        /// this method will input the distance measured in miles
        /// calculate the same distance in feet. and output the distance in feet.
        /// </summary>
        public void ConverterDistance()
        {
            fromUnit = SelectUnit("please select the from distance unit>");
            toUnit = SelectUnit("please select the to distance unit>");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance("please enter the number of {fromUnit} > ");
            CalculateDistance();
            OutPutDistance(fromDistance, fromUnit,toDistance, toUnit);
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n you have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }



        /// <summary>
        /// prompt the user to enter the distance in miles
        /// Input the miles as a two digit number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutPutDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}!");
        }
        ///<summary>
        ///
        /// </summary>
      
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("       distance converter        ");
            Console.WriteLine("         by Haider Imam          ");
            Console.WriteLine("-------------------------------\n");

        }
    }
}
