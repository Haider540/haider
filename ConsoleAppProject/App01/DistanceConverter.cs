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
        public const double FEET_IN_YARD = 3;

        public const double METRES_IN_MILES = 1609.344;
        public const double METRES_IN_KILOMETRES = 1000;

        public const double FEET_IN_METRES = 3.2808399;

        public const double YARD_IN_MILES = 1760;
        public const double YARD_IN_METRES = 1.0936133;
        public const double YARD_IN_KILOMETRES = 1093.6133;

        public const double CENTIMETRES_IN_FEET = 30.48;
        public const double CENTIMETRES_IN_MILES = 160934.4;
        public const double CENTIMETRES_IN_METRES = 100;
        public const double CENTIMETRES_IN_KILOMETRES = 100000;
        public const double CENTIMETRES_IN_YARDS = 91.44;

        public const double INCH_IN_METRES = 39.3701;
        public const double INCH_IN_KILOMETRES = 39370.078;
        public const double INCH_IN_MILES = 63360.24;
        public const double INCH_IN_FEET = 12;
        public const double INCH_IN_YARD = 36;
        public const double INCH_IN_CENTIMETRES = 0.3937;

        public const double KILOMETRES_IN_METRES = 1000;
        public const double KILOMETRES_IN_MILES = 1.609344;
        public const double KILOMETRES_IN_FEET = 3280.8399;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";
        public const string KILOMETRES = "kilometres";
        public const string YARD = "yard";
        public const string CENTIMETRES = "centimetres";
        public const string INCH = "inch";

        public double fromDistance;
        public double toDistance;

        public string fromUnit;
        public string toUnit;

        public double FromDistance { get; private set; }

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

            OutputHeading();
            do
            {
                fromUnit = SelectUnit("please select the from distance unit > ");
            } while (fromUnit == null);
            do
            {
                toUnit = SelectUnit("please select the to distance unit > ");
            } while (toUnit == null);


            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($"please enter the number of {fromUnit} > ");
            CalculateDistance();
            OutPutDistance(fromDistance, fromUnit, toDistance, toUnit);

        }


        public void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
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

            ///NEW UNIT KILOMETRES:
            if (fromUnit == METRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / METRES_IN_KILOMETRES;
            }

            else if (fromUnit == KILOMETRES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_KILOMETRES;
            }

            else if (fromUnit == KILOMETRES && toUnit == MILES)
            {
                toDistance = fromDistance / KILOMETRES_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * KILOMETRES_IN_MILES;
            }

            else if (fromUnit == KILOMETRES && toUnit == FEET)
            {
                toDistance = fromDistance / KILOMETRES_IN_FEET;
            }

            else if (fromUnit == FEET && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * KILOMETRES_IN_FEET;
            }

            ///NEW UNIT YARD:
            if (fromUnit == YARD && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_YARD;
            }

            else if (fromUnit == FEET && toUnit == YARD)
            {
                toDistance = fromDistance / FEET_IN_YARD;
            }
            else if (fromUnit == YARD && toUnit == MILES)
            {
                toDistance = fromDistance / YARD_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == YARD)
            {
                toDistance = fromDistance * YARD_IN_MILES;
            }
            else if (fromUnit == YARD && toUnit == METRES)
            {
                toDistance = fromDistance / YARD_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == YARD)
            {
                toDistance = fromDistance * YARD_IN_METRES;
            }
            else if (fromUnit == YARD && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / YARD_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == YARD)
            {
                toDistance = fromDistance * YARD_IN_KILOMETRES;
            }

            ///NEW UNIT CENTIMETRES:
            ///
            if (fromUnit == CENTIMETRES && toUnit == FEET)
            {
                toDistance = fromDistance / CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == FEET && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == CENTIMETRES && toUnit == MILES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == METRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_KILOMETRES;
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
            else if (choice.Equals("4"))
            {
                return KILOMETRES;
            }
            else if (choice.Equals("5"))
            {
                return CENTIMETRES;
            }
            else if (choice.Equals("6"))
            {
                return YARD;
            }

            else if (choice.Equals("7"))
            {
                return INCH;

            }
            return null;
        }



        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine($" 4. {KILOMETRES}");
            Console.WriteLine($" 5. {CENTIMETRES}");
            Console.WriteLine($" 6. {YARD}");

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
        /// this is the outputdistance.
        /// </summary>
        private void OutPutDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}!");
        }
        ///<summary>
        /// this is for when run it will show what it is for.
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