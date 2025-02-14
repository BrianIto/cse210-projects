using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Brian", "Addition");
        Console.WriteLine(a.GetSummary());
        MathAssignment m = new MathAssignment("Alice", "Subtraction", "Section 1", "1-20");
        Console.WriteLine(m.GetHomeworkList());
        WritingAssignment w = new WritingAssignment("Charlie", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(w.GetWritingInformation());
    }
}