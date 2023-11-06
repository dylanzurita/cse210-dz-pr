public class BreathingActivity : Activity
{
    public BreathingActivity (): base ("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}
    
    public void ControlBreathing ()
    {
        StartingMessage ();
        PromptForDuration();

        Console.WriteLine("Get Ready");
        AnimationsStrings();

        for (int i = 0; i < _activityDurationInput; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Countdown();
        }
        EndingMessage ();
    }

}