using System.ComponentModel.Design;

public class ActivityManager {

    private BreathingActivity _breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    private ReflectingActivity _reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilienc. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    private ListingActivity _listing = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    private ScreamingActivity _screaming = new ScreamingActivity("Screaming Activity", "This activity will help you release stress and other negative emotions by helping you vent by screaming out loud.");

    public void Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Start Screaming Activit");
        Console.WriteLine("5. Show me how many times I did each activity");
        Console.WriteLine("6. quit");
        Console.WriteLine("Select a number from the menu:");
    }

    public void ShowMenu()
    {
        string userInput = "";
        while (userInput != "6")
        {
            Menu();
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("");
                _breathing.StartMessage();
                _breathing.Run();
                _breathing.EndMessage();
                Console.WriteLine("");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("");
                _reflecting.StartMessage();
                _reflecting.Run();
                _reflecting.EndMessage();
                Console.WriteLine("");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("");
                _listing.StartMessage();
                _listing.Run();
                _listing.EndMessage();
                Console.WriteLine("");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("");
                _screaming.StartMessage();
                _screaming.Run();
                _screaming.EndMessage();
                Console.WriteLine("");
            }
            else if (userInput == "5")
            {
                Console.WriteLine("");
                Console.WriteLine($"You participated in the Breathing Activity {_breathing.GetTimesRun()} times.");
                Console.WriteLine($"You participated in the Reflecting Activity {_reflecting.GetTimesRun()} times.");
                Console.WriteLine($"You participated in the Listing Activity {_listing.GetTimesRun()} times.");
                Console.WriteLine($"You participated in the Screaming Activity {_screaming.GetTimesRun()} times.");
                Console.WriteLine("");  
            }
            else if (userInput == "6")
            {
                Console.WriteLine("See you next time!");
            }
            else {
                Console.WriteLine("!!---you did not enter a number listed in the menu, try again---!!");
                Console.WriteLine("");
            } 
        }
    }
}

