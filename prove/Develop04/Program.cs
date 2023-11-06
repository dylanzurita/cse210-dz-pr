using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine(" Menu Options:");
            Console.WriteLine(" 1. Start breathing Activity:");
            Console.WriteLine(" 2. Start reflecting Activity:");
            Console.WriteLine(" 3. Start listing Activity:");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();
        
            if (choice == "4")
                break;
            
            if (int.TryParse(choice, out int activityChoice))
            {
                Activity activity = null;
                
                switch ( activityChoice)
                {
                    case 1:
                        activity = new BreathingActivity();
                        break;
                    case 2:
                        activity = new ReflectionActivity();
                        break;
                    case 3:
                        activity = new ListingActivity();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid activity.");
                        break;
                }

                if (activity != null)
                {
                    switch (activityChoice)
                    {
                        case 1:
                            ((BreathingActivity)activity).ControlBreathing();
                            break;
                        case 2:
                            ((ReflectionActivity)activity).PerformReflection();
                            break;
                        case 3:
                            ((ListingActivity)activity).PerformListing();
                            break;
                    }
                }
            }
        }
    }
}