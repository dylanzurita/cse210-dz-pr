using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        int count = 0;
        
        int userNumber = -1; 
        
        while (userNumber != 0)
        {       
            Console.Write ("Enter number, type 0 when finished: ");
            int number = int.Parse (Console.ReadLine());
            
            if (userNumber != 0)
            {
                numbers.Add(number);
            }
        } 
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            count++;
        }

        int total = numbers.AsQueryable(). Sum();
        Console.Write ($"The sum is: {total}");
        int average = total / count;
        Console.Write ($"The average is: {average}");
        

    }
}



// do
        // {
        //     int userNumber = 0;
        //     while (userNumber == 0)
        // } while (true);