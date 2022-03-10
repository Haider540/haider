using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// this app shows your weight compared to your height.
    /// </summary>
    /// <author>
    /// Hiader Imam
    /// </author>
    public class BMI
    {
        public int Bmi { get; set; }

        public string Choice { get; set; }
        public string choice2;

        public double WeightStones { get; set; } 
        public double WeightPounds { get; set; } 

        public double HeightFeet { get; set; }
        public double HeightInches { get; set; }

        public double Weight { get; set; }
        public double Height { get; set; }

        // this is the Run Command
        public void Run()
        {
            //OutputHeading();

            
            do
            {
                Choice = SelectUnits();
            }
            while (Choice == null);

            if (Choice == "Metric")
            {
                InputMetric();
            }
            else
            {
                InputImperial();
            }

            CalculateBMI();
            OutputBMI();
            OutputBLAME();
        }

        public void OutputHeading()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("         BMI CALCULATOR     ");
            Console.WriteLine("         BY HAIDER IMAM     ");
            Console.WriteLine("            22130768        ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public string SelectUnits()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Please chose one of the showing Measurements");
            Console.WriteLine("No.| NAME  |    WEIGHT     |  HEIGHT      ");
            Console.WriteLine("1) IMPERIAL - STONES+POUNDS FEET/INCH");
            Console.WriteLine("2) METRIC   - KILOGRAM      METRES");
            Console.WriteLine("-----------");
            Console.WriteLine("Please enter 1 or 2");
            Choice = Console.ReadLine();
            if (Choice == "1")
            {
                return "imperial";
            }
            else if (Choice == "2")
            {
                return "Metric";
            }
            else
            {
                Console.WriteLine("Simple instructions, 1 or 2.");
                return null;
            }
        }


        public double InputMeasurement(string prompt, double measurement)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            
            if (Double.TryParse(value, out measurement))
            {
                measurement = Convert.ToDouble(value);
                if (measurement < 0)
                {
                    measurement = InputMeasurement("Negative, invalid input", measurement);
                    Console.Beep();
                }
                return measurement;
            }
            else
            {
                measurement = InputMeasurement("Negative, invaLid input", measurement);
                Console.Beep();
                return measurement;
            }
        }


        /// <summary>
        /// Method for the units
        /// </summary>
        private void InputImperial()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" WEIGHT STONES/POUNDS ADD HEIGHT FEET/INCH ");
            Console.WriteLine("-------------------------------------------");

            //this is for the weight
            WeightStones = InputMeasurement("ENTER THE WEIGHT IN STONES: ", WeightStones);
            WeightPounds = InputMeasurement("ENTER THE WEIGHT IN POUNDS: ", WeightPounds);
            Console.WriteLine("--------");

            //this is for the height
            HeightFeet = InputMeasurement("ENTER THE HEIGHT IN FEET: ", HeightFeet);
            HeightInches = InputMeasurement("ENTER THE HEIGHT IN INCH: ", HeightInches);

        }

        private void InputMetric()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" WEIGHT KILOGRAMS   add   HEIGHT METRES  ");
            Console.WriteLine("-----------------------------------------");

            Weight = InputMeasurement("ENTER THE WEIGHT IN KILOGRAM: ", Weight);
            Console.WriteLine("--------");
            Height = InputMeasurement("ENTER THE HEIGHT IN METRES", Height);
        }


        /// <summary>
        /// The calculations
        /// </summary>
        public void CalculateBMI()
        {
            if (Weight == 0)
            {
                Weight = (WeightStones * 14 + WeightPounds) * 703;
                Height = HeightFeet * 12 + HeightInches;
            }
            Bmi = (int)(Weight / (Height * Height));
        }

        /// <summary>
        /// To provide an output of BMI total.
        /// UNDERWEIGHT is below 18.50
        /// NORMAL 18.5 TO 24.9
        /// OVERWEIGHT 25.0 TO 29.9
        /// OBESE CLASS first 30.0 TO 34.9
        /// OBESE CLASS second 35 TO 39.9
        /// OBESE CLASS third >=40.0
        /// </summary>
        private void OutputBMI()
        {
            Console.WriteLine("---------------");
            Console.WriteLine($"Your BMI is {Bmi}");
            Console.WriteLine("----------------");

            //this is the answer when you chose your weight and height.
            if (Bmi < 18.5)
            {
                Console.WriteLine("BMI IS THAT YOU ARE UNDER-WEIGHT!");
            }
            else if (Bmi < 24.9)
            {
                Console.WriteLine("BMI IS THAT YOU ARE PERFECT");
            }
            else if (Bmi < 29.9)
            {
                Console.WriteLine("BMI IS THAT YOU ARE OVERRWEIGHT");
            }
            else if (Bmi < 34.9)
            {
                Console.WriteLine("BMI IS THAT YOU ARE OBESE CLASS FIRST");
                HighBMI();
            }
            else if (Bmi < 39.9)
            {
                Console.WriteLine("BMI IS THAT YOU ARE OBESE CLASS SECOND");
                HighBMI();
            }
            else
            {
                Console.WriteLine("BMI IS THAT YOU ARE OBESE CLASS THIRD");
                HighBMI();
            }

        }

        private void OutputBLAME()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 DANGEROUS               ");
            Console.WriteLine("BAME RULES states ");
            Console.WriteLine("AND IS ALSO A FACT");
            Console.WriteLine("asian");
            Console.WriteLine("balck");
            Console.WriteLine("many other ethnics");
            Console.WriteLine("THEY ARE MORE LIKELY TO BE OVER WEIGHT   ");
            Console.WriteLine("BECAUSE OF THE FOOD AND GENES.           ");
            Console.WriteLine("-----------------------------------------");
        }

        private void HighBMI()
        {
            Console.Beep();
            Console.WriteLine("=========================================");
            Console.WriteLine("                   URGENT                ");
            Console.WriteLine("        HIGH BMI HAS BEEN SPOTTED        ");
            Console.WriteLine("High BMI can cause many problems         "); 
            Console.WriteLine(" GO TO THE DOCTOR MATE OR GYM            ");
            Console.WriteLine("=========================================");

        }



    }
}