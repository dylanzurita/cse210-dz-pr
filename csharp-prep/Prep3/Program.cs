using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 50);
        
        int unumber = -1;
             
        while (unumber != number)
        {
            Console.Write("What is you guess? ");
            unumber = int.Parse(Console.ReadLine()); 

            if (unumber < number)
            {
                Console.WriteLine ("higher");
            }
            else if (unumber > number)
            {
                Console.WriteLine ("lower");
            }
            else
            {
                Console.WriteLine ("You guessed it");
            }
        }
    }
}