namespace StudentManagement.Input
{
    public class InputHandler
    {
        public string GetStudentName()
        {
            Console.WriteLine("Enter student name: ");
            return Console.ReadLine()!;
        }

        public int GetGrade()
        {
            Console.WriteLine("Enter a grade: ");
            return int.Parse(Console.ReadLine()!);
        }
    }
}
