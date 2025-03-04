public class ReflectingActivity : Activity {
    public ReflectingActivity(string activityName, string description) : base(activityName, description)
    {}

    private List<string> _startPrompts = new List<string>
    {
        "---Think of a time when you stood up for someone else.---",
        "---Think of a time when you did something really difficult.---",
        "---Think of a time when you helped someone in need.---",
        "---Think of a time when you did something truly selfless.---"
    };

    private List<string> _askPrompts = new List<string>
    {
       "Why was this experience meaningful to you?",
       "Have you ever done anything like this before?",
       "How did you get started?",
       "How did you feel when it was complete?",
       "What made this time different than other times when you were not as successful?",
       "What is your favorite thing about this experience?",
       "What could you learn from this experience that applies to other situations?",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future?"
    };

    public string GetStartPrompt()
    {
        int index = random.Next(_startPrompts.Count);
        return _startPrompts[index];
    }

    public string GetAskPrompt()
    {
        int index = random.Next(_askPrompts.Count);
        return _askPrompts[index];
    }

    public void Continue()
    {
        Console.WriteLine("If you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        if (string.IsNullOrEmpty(userInput)) return; //if enter is pressed, it exits out of the function
    }

    public void Run()
    {
        Console.WriteLine("");
        Console.WriteLine("Consider the following pompt:");
        Console.WriteLine(GetStartPrompt());
        Continue();
        Console.WriteLine("Now ponder on each questions as they relate to this experience.");
        ShowCountdown(3);
       
        DateTime startTime = DateTime.Now;
        DateTime duration = startTime.AddSeconds(GetTime());
 
        while (DateTime.Now < duration)
        {
            Console.WriteLine("");
            Console.WriteLine(GetAskPrompt());
            LoadAnimation(5);
        }
        Console.WriteLine("");
        _timesRun++;
    }
}