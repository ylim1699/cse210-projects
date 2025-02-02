using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        
        // variables for each classes 
        Journal journal = new Journal();
        PromptGenerator random = new PromptGenerator();
        
        // find the author's full name and store it in entry.cs
        Console.Write("What is your full name?");
        string author = Console.ReadLine();

        int userInput(string author)
        {
        
            Console.WriteLine($"Hello {author}, Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Delete Display entries");
            Console.WriteLine("6.Delete file entries");
            Console.WriteLine("7.Quit");

            Console.Write("What would you like to do? (select a number):");
            int userResponse = int.Parse(Console.ReadLine());
            return userResponse;
        };
        
        int userResponse = userInput(author);

        while (userResponse != 7)
        {

            if (userResponse == 1)
            {
                Console.WriteLine("");
                string prompt = random.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry newEntry = new Entry(date, author, prompt, response);
                journal.AddList(newEntry);

                Console.WriteLine("");
            } 
            else if (userResponse == 2)
            {
                journal.DisplayAll();
                Console.WriteLine("");
            }
            else if (userResponse == 3)
            {
                Console.WriteLine("Which file would you like to load from?:");
                journal._filename = Console.ReadLine();
                journal.LoadFromFile();
                Console.WriteLine("");
            }
            else if (userResponse == 4)
            {
                Console.Write("Which file would you like to save it to?:");
                journal._filename = Console.ReadLine();
                journal.SaveToFile(journal._entries);
                Console.WriteLine("");
            }    
            else if (userResponse == 5)  
            {
                journal._entries.Clear();
                journal._savedEntries ="";
                Console.WriteLine("");
            }   
            else if (userResponse == 6) 
            {
                Console.WriteLine("Which file would you like to delete the entries:");
                journal._filename = Console.ReadLine();
                journal.DeleteFileEntries();
            } 

            // After it goes through the while function, activates the function from the start again
            userResponse = userInput(author);
        };
    }
}
