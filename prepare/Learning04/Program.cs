using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment student1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(student1.GetSummary());

        MathAssignment mathstudent = new MathAssignment("Roberto Rodríguez", "Fractions","7.3", "8-19");
        Console.WriteLine(mathstudent.GetSummary());
        Console.WriteLine(mathstudent.GetHomeworkList());

        WritingAssignment writingstudent = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        Console.WriteLine(writingstudent.GetSummary());
        Console.WriteLine(writingstudent.GetWritingInformation());
    }
}