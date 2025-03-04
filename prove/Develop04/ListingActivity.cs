using System.ComponentModel;
using System.Dynamic;

public class ListingActivity : Activity {
    public ListingActivity(string activityName, string description) : base(activityName, description)
    {}

    private List<string> _prompts = new List<string> 
    {
        "---Who are people that you appreciate?---",
        "---What are personal strengths of yours?---",
        "---Who are people that you have helped this week?---",
        "---When have you felt the Holy Ghost this month?---",
        "---Who are some of your personal heroes?---"
    };

    private List<string> _answer = new List<string>();

    public string GetPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
       Console.WriteLine("Write as many responses to the following prompt:");
       Console.WriteLine(GetPrompt());
       ShowCountdown(3);
       
       DateTime startTime = DateTime.Now;
       DateTime duration = startTime.AddSeconds(GetTime());

       while (DateTime.Now < duration)
       {
        Console.Write(">");
        string answer = Console.ReadLine();
        _answer.Add(answer);
       }
       Console.WriteLine($"You listed {_answer.Count} items!");
    }

}