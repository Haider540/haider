using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Haider Imam 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Haider                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.Beep();

            Menu();

        }

        // User selects the app which they want to use 
        private static void Menu()
        {
            Console.WriteLine("Which app do you want to select? : ");
            string[] choices = { "Distance Converter", "BMI Calculator", "Social Network", "Student Marks" };
            string choice = Console.ReadLine();

            //first app
            if (choice == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.ConverterDistance();
            }
            else if (choice == "2")
            {
                BMI bmi = new BMI();
                bmi.Run();
            }
            else if (choice == "3")
            {
                StudentGrades grades = new StudentGrades();
                grades.Run();
            }
            else if (choice == "4")
            {
                SocialNetwork social = new SocialNetwork();
                social.DisplayMenu();
            }
            else
            {
                Console.WriteLine("1 2 or 3 mmmmmmmmm");
            }


        }
    }
}

