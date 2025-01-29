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
            Console.WriteLine("5.Delete (journal entries saved in txt file)");
            Console.WriteLine("6.Delete (recorded entries in display)");
            Console.WriteLine("7.Quit");

            Console.Write("What would you like to do? (select a number):");
            int userResponse = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return userResponse;
        };
        
        int userResponse = userInput(author);

        while (userResponse != 7)
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
                Console.WriteLine("");
            } 
            else if (userResponse == 2)
            {
                Console.WriteLine("");
                entry.Display();
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
                journal.SaveToFile(entry._combinedStrings);
                Console.WriteLine("");
            }
            else if (userResponse == 5)
            {
                Console.WriteLine("Choose the file name of the journal entries you would like to empty:");
                journal._filename = Console.ReadLine();
                journal.DeleteJournalEntries();
                Console.WriteLine("");
            }
            else if (userResponse == 6)
            {
                entry.DeleteDisplay();
            }

            // After it goes through the while function, activates the function from the start again
            userResponse = userInput(author);
        };
    }
}