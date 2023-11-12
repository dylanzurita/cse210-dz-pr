public class BreathingActivity : Activity
{
    public BreathingActivity (): base ("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}
    
    public void ControlBreathing ()
    {
        StartingMessage ();
        PromptForDuration();

        Console.WriteLine("Get Ready");
        AnimationsStrings();

        while (_activityDurationInput > 0)
        {
            Console.WriteLine("Breathe in... up to five");
            Thread.Sleep(5000);

            Console.WriteLine ("Breathe out... down to one");
            Thread.Sleep(5000);

            _activityDurationInput -= 5;

        }
        EndingMessage ();
    }

}


