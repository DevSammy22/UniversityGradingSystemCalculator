using Grading_System;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingSystem
{
    public class GradingCalculation
    {
        public static List<CourseDetails>  courseList = new List<CourseDetails>();

        public void AddCourse()
        {
            string checkNum;
            string courseCode; //= string.Empty;
            //string courseCodeCheck;
            int courseUnit = 0;
            string courseUnitCheck;
            double courseScore = 0;
            string courseScoreCheck;
            string grade = string.Empty;
            int gradeUnit = 0;
            string remark = string.Empty;


            Console.Write("Enter Number of Courses: ");

            checkNum = Console.ReadLine();

            while (Validation.CourseNumberCheck(checkNum) == false)
            {
                Console.Write("Invalid input! \nPlease, enter valid input number again: ");
                checkNum = Console.ReadLine();
            }
            
            double totalCourse = double.Parse(checkNum.Trim());

            //double totalCourse = double.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < totalCourse; i++)
            {
               Console.WriteLine($"No.{i + 1} - Enter Course Name and Code : ");
                //Console.Write("No." + "" + (i + 1) + " " + "-" + " " + "Enter Course Name and Code " + " : ");
                //courseCode = Console.ReadLine().Trim();
               
                courseCode = Console.ReadLine().Trim();

                //bool validRes = Validation.isLetterNumber(courseCode);
                while(Validation.isLetterNumber(courseCode) == false)
                {
                    Console.Write("Invalid input! \nPlease, enter valid input: ");
                    courseCode = Console.ReadLine();
                }
                //courseCode = Console.ReadLine().Trim();
                
                Console.Write("Enter " + courseCode.ToUpper() + " Unit: ");
                courseUnitCheck = Console.ReadLine().Trim();


                while (Validation.UnitCheck(courseUnitCheck) == false || Validation.Condition(courseUnitCheck) < 1 || Validation.Condition(courseUnitCheck) > 5)
                {
                    Console.WriteLine("Re-enter the unit please: ");
                    courseUnitCheck = Console.ReadLine().Trim();
                }
                courseUnit = int.Parse(courseUnitCheck);
                Console.Write("Enter " + courseCode + " Score: ");
                courseScoreCheck = Console.ReadLine().Trim();
               
                while (Validation.ScoreCheck(courseScoreCheck) == false || Validation.Condition(courseScoreCheck) < 0 || Validation.Condition(courseScoreCheck) > 100)
                {
                    Console.WriteLine("Re-enter the score please: ");
                    courseScoreCheck = Console.ReadLine().Trim();
                }
                courseScore = double.Parse(courseScoreCheck);

                //courseScore = double.Parse(Console.ReadLine());
                Console.Clear();

                
                if (courseScore >= 0 && courseScore <= 39)
                {
                    grade = Grades.F.ToString();  //Enum.GetName(typeof(Grades), 0); //hpw are we able to get enum
                    gradeUnit = (int)Grades.F;
                    remark = Remarks.Fail;
                }
                else if (courseScore >= 40 && courseScore <= 44)
                {
                    grade = Enum.GetName(typeof(Grades), 1);
                    gradeUnit = (int)Grades.E;
                    remark = Remarks.Pass;
                }
                else if (courseScore >= 45 && courseScore <= 49)
                {
                    grade = Enum.GetName(typeof(Grades), 2);
                    gradeUnit = (int)Grades.D;
                    remark = Remarks.Fair;
                }
                else if (courseScore >= 50 && courseScore <= 59)
                {
                    grade = Enum.GetName(typeof(Grades), 3); ;
                    gradeUnit = (int)Grades.C;
                    remark = Remarks.Good;
                }
                else if (courseScore >= 60 && courseScore <= 69)
                {
                    grade = Enum.GetName(typeof(Grades), 4);
                    gradeUnit = (int)Grades.B;  //Enum.GetValues(typeof(Grades);
                    remark = Remarks.VeryGood;
                }
                else if (courseScore >= 70 && courseScore <= 100)
                {
                    grade = Enum.GetName(typeof(Grades), 5);
                    gradeUnit = (int)Grades.A;
                    remark = Remarks.Excellent;
                }

               var weightPoint = courseUnit * gradeUnit;

                CourseDetails gradeDetails = new CourseDetails (courseCode, courseUnit, grade, gradeUnit, weightPoint, remark);

                //CourseDetails gradeDetails = new CourseDetails();
                //gradeDetails.CourseCode = courseCode;
                //gradeDetails.WeightPoint = weightPoint;
                //gradeDetails.CourseUnit = courseUnit;
                //gradeDetails.Grade = grade;
                //gradeDetails.Remark = remark;

                courseList.Add(gradeDetails);

               
            }
        }

        public void ResultSummary()
        {
            double totalWeightPoint = courseList.Select(x => x.WeightPoint).Sum();
            int totalGradeUnit = courseList.Select(x => x.GradeUnit).Sum();
            int totalCourseUnit = courseList.Select(x =>x.CourseUnit).Sum();
            double gpa = Math.Round(((double)totalWeightPoint / (double)totalCourseUnit), 2) ;

            Console.WriteLine($"Total Weight Point: {totalWeightPoint}");
            Console.WriteLine($"Total Grade Unit: {totalCourseUnit}");
            Console.WriteLine($"Total Grade Unit: {totalGradeUnit}");
            Console.WriteLine($"GPA: {gpa}");
        }

        public void PrintResult() //why is this void
        {
            PrintTable.Print();
            Console.WriteLine();
            Console.WriteLine();

            /*for (int i = 0; i < courseList.Count; i++)
            {
                Console.Write(courseList[i].CourseCode + " ");
                Console.Write(courseList[i].CourseUnit + " ");
                Console.Write(courseList[i].Grade + " ");
                Console.Write(courseList[i].GradeUnit + " ");
                Console.Write(courseList[i].WeightPoint + " ");
                Console.Write(courseList[i].Remark + " \n");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            ResultSummary();
            Console.WriteLine();
            Console.WriteLine();*/
        }
    }
}