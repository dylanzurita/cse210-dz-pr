// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop05 World!");
//     }
// }
using System;

class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration(int seconds)
    {
        Duration = seconds;
    }

    public void Start()
    {
        Console.WriteLine($"{Name} - {Description}");
    }

    public void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"{Name} - Completed in {Duration} seconds");
        AnimateSpinner(5); // Animate a spinner for 5 seconds
    }

    public void PromptForDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            SetDuration(duration);
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }

    protected void AnimateSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }
}

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "Relax by focusing on your breath") { }

    public void PerformBreathing()
    {
        Start();
        PromptForDuration(); // Prompt for duration here

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            AnimateCountdown(5); // Animate countdown for 5 seconds
        }
        End();
    }

    private void AnimateCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            System.Threading.Thread.Sleep(1000); // Pause for 1 second
        }
    }
}

// Other child classes (ReflectionActivity, ListingActivity) can follow a similar structure.

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "4")
                break;

            if (int.TryParse(choice, out int activityChoice))
            {
                Activity activity = null;

                switch (activityChoice)
                {
                    case 1:
                        activity = new BreathingActivity();
                        break;
                    // Handle other activity choices
                }

                if (activity != null)
                {
                    switch (activityChoice)
                    {
                        case 1:
                            ((BreathingActivity)activity).PerformBreathing();
                            break;
                        // Handle other activity choices
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
            }
        }
    }
}
