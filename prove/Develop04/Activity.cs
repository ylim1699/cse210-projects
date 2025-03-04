public class Activity {
    private int _time;
    private string _activityName;
    private string _description;
    protected int _timesRun = 0;
    protected Random random = new Random();

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public int GetTimesRun()
    {
        return _timesRun;
    }

    public void LoadAnimation(int s) //2 seconds of loading per 1 value of s.
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

    public void ShowCountdown(int s) //s = amount of countdown in seconds.
    {
        Console.WriteLine("you may begin in:");
        for (int i = s; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetTime()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        string time = (Console.ReadLine());

        if (int.TryParse(time, out int number)) // checks to see if the first argument in the parameter of int.TryParse could be an int type, and if it is, it out(outputs) a new variable "int number".
        {
            _time = number;
        }
        else 
        {
            Console.WriteLine("");
            Console.WriteLine("!!---You did not enter a nubmer. Try again---!!");
            SetTime();
        }
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
}