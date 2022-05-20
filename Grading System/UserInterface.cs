using System;
using System.Collections.Generic;
using System.Text;


namespace GradingSystem
{
    public class UserInterface
    {
        public static void Begin()
        {
            GradingCalculation gradingCalculation = new GradingCalculation();

            Console.WriteLine("\t\t\t\t\t\t\t\tGrading System Calculator");
            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------");

            bool valid = true;
            while (valid)
            {
                
                Console.WriteLine("Press 1 to add course");
                Console.WriteLine("Press 2 to print result");
                Console.WriteLine("Press any key to exit");

                
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    Console.Clear();
                    gradingCalculation.AddCourse();
                }
                else if (userChoice == "2")
                {
                    Console.Clear();
                    gradingCalculation.PrintResult();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
         
        }
    }
}


