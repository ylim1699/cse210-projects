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

            Console.Write("What would you like to do today? (select a number):");
            int userResponse = int.Parse(Console.ReadLine());
            Console.WriteLine("");
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
                journal._combinedStrings.Add(combinedEntry);
            } 
            else if (userResponse == 2)
            {
                Console.WriteLine("");
                journal.Display();
            }
            else if (userResponse == 3)
            {
                Console.WriteLine("Which file would you like load your journal entries from?");
                journal._filename = Console.ReadLine();
                journal.LoadFromFile();
                Console.WriteLine("");
            }
            else if (userResponse == 4)
            {
                Console.WriteLine("Which file would you like to save your journal entries to?");
                journal._filename = Console.ReadLine();
                journal.SaveToFile(journal._combinedStrings);
                Console.WriteLine("");
            }

            userResponse = userInput(author);
        };
        


    }
}