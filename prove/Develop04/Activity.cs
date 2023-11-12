public class Activity
{
    private string _activityName = " ";
    private string _activityDescription = " ";
    protected int _activityDurationInput;

    public Activity (string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;

    }
    public void SetDuration (int seconds)
    {
        _activityDurationInput = seconds;
    }

    public string StartingMessage ()
    {
        return $"Welcome to the {_activityName}. \n {_activityDescription}.";
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
    public void AnimationsStrings()
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep (700);
            Console.Write("\b \b");
        }
    }    

    public void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    
    public void EndingMessage ()
    {
        Console.WriteLine ("Well Done!!");
        AnimationsStrings();
        Console.WriteLine($"You have completed another {_activityDurationInput} seconds of the {_activityName}.");
    }
}