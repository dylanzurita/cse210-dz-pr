using System;

class Program
{
    static void Main(string[] args)
    {  
        DisplayWelcome();
        string uName = PromptUserName();
        int uNumber =PromptUserNumber();
        int uSquareNumber = SquareNumber(uNumber);
        DisplayResult (uName, uSquareNumber);
    }
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the Program !");
    }
    static string PromptUserName ()
    {
        Console.WriteLine ("Please enter your name: ");
        string name = Console.ReadLine();
        return name; 
    }
    static int PromptUserNumber ()
    {
        Console.WriteLine ("Please enter your favorite number: ");
        string number = Console.ReadLine(); 
        int unumber = int.Parse(number);
        return unumber;
    }
    static int SquareNumber (int uNumber)
    {
        int squaredNumber = uNumber * uNumber;
        
        return squaredNumber;
    }
    static void DisplayResult (string uName, int uSquareNumber)
    {
        Console.WriteLine($"{uName}, the square of your number is {uSquareNumber}");
    }

    
}