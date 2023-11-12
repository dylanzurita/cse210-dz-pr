public class ListingActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> answers = new List<string>
    {};
    public ListingActivity() : base("Listing Activity", "List positive aspects of your life") { }

    public void PerformListing()
    {
        StartingMessage();
        PromptForDuration();

        Console.WriteLine("Get Ready");
        AnimationsStrings();

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        AnimationsStrings(); 

        Console.WriteLine("Start listing items..."); 
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDurationInput);

        while (DateTime.Now < endTime)
        {
            string listedItem = Console.ReadLine();
            answers.Add(listedItem);
        }
  

        EndingMessage();
    }
}

//     private void AnimateCountdown(int seconds)
//     {
//         for (int i = seconds; i > 0; i--)
//         {
//             Console.WriteLine($"Countdown: {i}");
//             System.Threading.Thread.Sleep(1000); 
//         }
//     }
// }