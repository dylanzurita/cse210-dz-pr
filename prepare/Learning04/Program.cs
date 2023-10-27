using System;

class Program 
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment ("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssingment = new MathAssignment ("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine (mathAssingment.GetSummary());
        Console.WriteLine (mathAssingment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment ("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine (writingAssignment.GetSummary());
        Console.WriteLine (writingAssignment.GetWritingInformation());
    
    }

}

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
//         Console.WriteLine(a1.GetSummary());

//         MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
//         Console.WriteLine(a2.GetSummary());
//         Console.WriteLine(a2.GetHomeworkList());

//         WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
//         Console.WriteLine(a3.GetSummary());
//         Console.WriteLine(a3.GetWritingInformation());
//     }
// }