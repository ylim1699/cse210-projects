public class Activity {
    private int _time;
    private string _activityName;
    private string _description;
    protected Random random = new Random();

    public Activity()
    {}
    
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void LoadAnimation(int s)
    {
        for (int i = s; i > 0; i--)
        {
            Console.Write("/"); 
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("—"); 
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("\\");
            Thread.Sleep(500); 
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b") ;
        }
    }
    public void SetTime()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        int time = int.Parse(Console.ReadLine());
        _time = time;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Wecome to the {_activityName}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        SetTime();
        Console.WriteLine("get ready...");
        Console.WriteLine("");
        LoadAnimation(2);
    }

    public void EndMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
        Console.WriteLine("");
        Console.WriteLine($"you have completed another {_time} sec of {_activityName}.");
        LoadAnimation(2);
    }

    public int GetTime()
    {
        return _time;
    }
    public void ShowCountdown(int s)
    {
        Console.WriteLine("you may begin in:");
        for (int i = s; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}