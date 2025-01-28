using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts = new List<string>
    {
        "What was the most memorable thing today?",
        "What was your favorite part about today?",
        "Describe your day in 1 sentence",
        "What do you think you could've done better today?",
        "Were you 1 percent better today?"
    };
    
    public Random random = new Random();
    
    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }


    // stores random prompts
}