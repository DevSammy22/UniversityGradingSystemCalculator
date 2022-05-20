using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GradingSystem
{
    public static class Validation
    {

        private static string CourseCheck = "^[a-zA-Z]{3}[0-9]{3}";

        public static bool isLetterNumber(string letternumber)
        {
            return Regex.IsMatch(letternumber, CourseCheck) ? true : false;
        }
        
        public static bool UnitCheck(string check)
        {
            
            return int.TryParse(check, out _) ? true: false;

        }

        public static int Condition(string value)
        {
            int result = -1;
            var response = int.TryParse(value, out result);
            if (response)
            {
                return result;
            }
            return result;
        }

        public static bool ScoreCheck(string check)
        {
            return double.TryParse(check, out _) ? true : false;

        }
        public static bool CourseNumberCheck(string check)
        {
            return double.TryParse(check, out _) ? true : false;

        }

    }
}
