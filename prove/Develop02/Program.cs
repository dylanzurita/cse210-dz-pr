using System;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your personal Journal");
        Console.WriteLine();
        Console.WriteLine("We know it can be difficult to keep a journal up to date, that is why...");
        Console.WriteLine("We present to you this program that can resolve this and many other problems. For you to keep an active journal of your daily life.");
        Console.WriteLine();
        Console.WriteLine("First things first");
        Console.Write("With whom do I have the pleasure? ");
        string name = Console.ReadLine();
        Console.Write("How old are you? ");
        string age = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Ok {name}, nice to meet you. Each day we will send you a notification, reminding you that you have a journal to write");
        Console.WriteLine("We will suggest a question for you to answer in case you do not know how to start. Or simply an empty page for you to write anything you like.");
        Console.WriteLine();

        promptGenerator getPrompt1 = new promptGenerator ();
        getPrompt1.getPrompt();
        
    }
}

public class promptGenerator 
{
    
    public void getPrompt()
    {
        int decision = 0;
        string questionRand = "";
        string response= "";
        while (decision != 5)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save your entries");
            Console.WriteLine("4. Load your Journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string opcion = Console.ReadLine();
            decision = int.Parse(opcion);
            
            
            
            if (decision == 1)
            {
                Console.WriteLine("Would you like one of our questions or an empty page ? (1 or 2)");
                string decision1 = Console.ReadLine();
                int dec1 = int.Parse(decision1);

                if (dec1 == 1)
                {
                    List<string> questions = new List<string>(){ "Who was the most interesting person I interacted with today? ",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?",
                    "What I learned today ",
                    };
                    Random random = new Random();
                    int q = random.Next (questions.Count);
                    questionRand = questions[q];
                    Console.WriteLine(questionRand);
                    response = Console.ReadLine();
                }
                else {
                    questionRand = "Free Entry";
                    Console.WriteLine("You can start typing... (press enter to finish)");
                    response = Console.ReadLine();
                }
            }
            else if (decision == 2)
            {
                 if ( questionRand == "" && response == "")
                {
                    Console.WriteLine ("No new entries");
                }
                else 
                {
                    dEntries displayEntry = new dEntries ();
                    displayEntry.displayE(questionRand, response);
                }
            }

            else if (decision == 3)
            {
                if ( questionRand == "" && response == "")
                {
                    Console.WriteLine ("No new entries");
                }
                else 
                {
                    saveEntries saveEntry = new saveEntries ();
                    saveEntry.saveE(questionRand, response);
                    questionRand = "";
                    response = "";
                }
            }
            else if (decision == 4)
            {
                loadJournal lJournal = new loadJournal ();
                lJournal.loadJ();
            }
        }    

    }

}

public class dEntries
{
    public string questionRand {get; set;}
    public string response {get; set;}
    
    public void displayE (string questionRand, string response)
    {
        Console.WriteLine(questionRand);
        Console.WriteLine(response);
    }

}

public class saveEntries 
{
    public string questionRand {get; set;}
    public string response {get; set;}

    public void saveE (string questionRand, string response)
    {
        string routeFile = "journal.csv";
        using (StreamWriter writer = new StreamWriter(routeFile,true))
        {
            DateTime actualDate = DateTime.Now;
            string formattedDate = actualDate.ToString("yyyy-MM-dd HH:mm:ss");
            string line = string.Join(": ", formattedDate, questionRand, response);
            writer.WriteLine(line);
        }        
    }
}
public class loadJournal 
{

    public void loadJ ()
    {
        string routeFile = "journal.csv";
        using (TextFieldParser parser = new TextFieldParser(routeFile))
        {
            while (!parser.EndOfData)
            {
                string line = parser.ReadLine(); 
                Console.WriteLine(line);
            }
        }     
    }
}