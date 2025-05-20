
namespace StudentManagement.Output
{
    public class OutputHandler
    {
        public void DisplayResults(string name, int grade, string result)
        {
            Console.WriteLine($"Student: {name}, Grade: {grade}, Result: {result}");
        }
    }
}
