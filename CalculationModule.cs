namespace StudentManagement.Calculation
{
    public class GradeCalculator
    {
        public string CalculateGrade(int grade)
        {
            string result;

            switch (grade)
            {
                case >= 90:
                    result = "Excellent";
                    break;
                case >= 75:
                    result = "Good";
                    break;
                case >= 60:
                    result = "Pass";
                    break;
                default:
                    result = "Fail";
                    break;
            }

            return result;
        }
    }
}
