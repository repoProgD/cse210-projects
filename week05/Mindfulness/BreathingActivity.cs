public class BreathingActivity: Activity
{
    // Constructor -> base Constructor -> Activity(name, description) => base(name, description)
    public BreathingActivity()
    : base("Breathing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    public void Run()
    {
        // begin with the standar starting message
        DisplayStartingMessage();

        // Alternating Breathe in and Breathout messages

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in... ");
            ShowCountDown();

            if (DateTime.Now >= endTime) break;

            Console.WriteLine("\nBreathe out...");
            ShowCountDown();
        }

        DisplayEndingMessage();

    }
    
}