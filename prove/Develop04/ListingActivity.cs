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
                Console.ReadLine();

        Console.WriteLine($"Number of items listed: ");

        EndingMessage();
    }

    private void AnimateCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            System.Threading.Thread.Sleep(1000); 
        }
    }
}