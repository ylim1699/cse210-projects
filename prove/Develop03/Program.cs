class Program
{
    static void Main(string[] args)
    {
        ScriptureGenerator randomScripture = new ScriptureGenerator();
        Reference reference = new Reference();
        
        randomScripture.LoadFromFile();
        Scripture scripture = new Scripture(randomScripture.GetRandomPrompt());
        
        Console.WriteLine($"Here is your given scripture: {scripture.Display()}");
        Console.WriteLine("");
        Console.WriteLine("Press enter to start playing scripture memorizer");
        Console.WriteLine("If you type quit, you can exit out of the program");
        string userInput = Console.ReadLine();

        while (scripture.IsCompletelyHidden() != true && userInput != "quit")
        {  
            Console.WriteLine("Press enter to hide words little by little or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                scripture.HideWord();
                Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine("");
                
            }
            else if (userInput == "quit")
            {
                Console.WriteLine("Thanks for playing!");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

//================================================================================================================================//

        // // test to see if reference comes out properly
        // Console.WriteLine(reference.GetReference());
        
        // // test to see if the list of word objects are stored and outputs properly
        // foreach (Word word in scripture.GetWord())
        // {
        //     Console.WriteLine(word.GetText());
        // }

    }
}















































