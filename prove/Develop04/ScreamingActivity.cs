public class ScreamingActivity : Activity {
    public ScreamingActivity(string activityName, string description) : base(activityName, description)
    {}
    private List<string> _screamAnimation = new List<string>
    {
        "placeholder","<<<<<{(())}","<<<<((()))","<<<(())","<<()","placeholder"
    };

    public void Run()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime duration = startTime.AddSeconds(GetTime());
        
        while (DateTime.Now < duration)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write($" {_screamAnimation[i]} ");
                Console.Write($"\rScream!!...{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("");
            Console.WriteLine("");   

            for (int i = 5; i > 0; i--)
            {
                Console.Write($"\rBreathe in and relax...{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }
        _timesRun++;
    }
}