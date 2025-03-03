using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity {
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {}
    
    public void Run()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime duration = startTime.AddSeconds(GetTime());
        
        while (DateTime.Now < duration)
        {
            for (int i = 4; i > 0; i--)
            {     
                Console.Write("\rBreathe in...");
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 6; i > 0; i--)
            {
                Console.Write("\rNow reathe out..."); 
                Console.Write(i);
                Thread.Sleep(1000); 
                Console.Write("\b \b");
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}