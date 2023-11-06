public class ReflectionActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "Reflect on moments of strength and resilience") { }

    public void PerformReflection()
    {
        StartingMessage();
        PromptForDuration(); 

        Console.WriteLine("Get Ready");
        AnimationsStrings();

        Random random = new Random();
        for (int i = _activityDurationInput; i > 0; i--)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            AnimationsStrings(); // Animate a spinner for 5 seconds

            foreach (var question in questions)
            {
                Console.WriteLine(question);
                AnimationsStrings(); // Animate a spinner for 5 seconds
            }
        }
        EndingMessage();
    }
}
