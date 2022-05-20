namespace GradingSystem
{
    public class CourseDetails
    {
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public string Grade  { get; set; }
        public int GradeUnit { get; set; }
        public int WeightPoint { get; set; }
        public string Remark { get; set; }

        public CourseDetails(string courseCode, int courseUnit, string grade, int gradeUnit, int weightPoint, string remarks)
        {
            CourseCode = courseCode;
            CourseUnit = courseUnit;
            Grade = grade;
            GradeUnit = gradeUnit;
            WeightPoint = weightPoint;
            Remark = remarks;
        }
    }
}