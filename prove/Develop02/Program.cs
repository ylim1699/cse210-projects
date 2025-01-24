using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // variables for each classes 
        Entry entry = new Entry();
        Journal journal = new Journal();
        PromptGenerator random = new PromptGenerator();
        
        // find the author's full name and store it in entry.cs
        Console.Write("What is your full name?");
        string author = Console.ReadLine();
        entry._author = author;

        int userInput(string author)
        {
        
            Console.WriteLine($"Hello {author}, Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");

            Console.Write("What would you like to do today? (select a number):\n");
            int userResponse = int.Parse(Console.ReadLine());
            return userResponse;
        };
        
        int userResponse = userInput(author);

        while (userResponse != 5)
        {

            if (userResponse == 1)
            {
                string prompt = random.GetRandomPrompt();
                
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                
                entry._promptQuestion = prompt;
                entry._response = response; 
                string combinedEntry = entry.GetFromUser();
                entry._combinedStrings.Add(combinedEntry);
            } 
            else if (userResponse == 2)
            {
                Console.WriteLine("");
                entry.Display();
            }
            else if (userResponse == 3)
            {

            }
            else if (userResponse == 4)
            {

            }

            userResponse = userInput(author);
        };
        


    }
}