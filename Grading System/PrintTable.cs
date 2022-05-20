using GradingSystem;
using System;

namespace Grading_System
{
    public class PrintTable
    {
        static int TableWidth = 67;
        public static void Print()
        {
            if (GradingCalculation.courseList.Count != 0)
            {
                Console.WriteLine("Your result summary is:");
                Console.WriteLine();
                Line();
                PrintRow("Course", "Unit", "Grade", "G. Unit", "Wt Point", "Remark");
                Line();

                foreach (var item in GradingCalculation.courseList)
                {
                    PrintRow($"{item.CourseCode}", $"{item.CourseUnit}", $"{item.Grade}", $"{item.GradeUnit}", $"{item.WeightPoint}", $"{item.Remark}");
                    Line();
                }
                GradingCalculation call = new GradingCalculation();
                call.ResultSummary();
            }
            else
                Console.WriteLine("No course added yet!");
        }
        static void Line()
        {
            Console.WriteLine(new string('-', TableWidth));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (TableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach (string column in columns)
            {
                row += CentreAlignment(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        static string CentreAlignment(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
