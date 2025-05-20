using System;
using StudentManagement.Input;
using StudentManagement.Output;
using StudentManagement.Calculation;


class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        GradeCalculator gradeCalculator = new GradeCalculator();
        OutputHandler outputHandler = new OutputHandler();

        string name = inputHandler.GetStudentName();
        int grade = inputHandler.GetGrade();
        string result = gradeCalculator.CalculateGrade(grade);
        outputHandler.DisplayResults(name, grade, result);
    }
}
