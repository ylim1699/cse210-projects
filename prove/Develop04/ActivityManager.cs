using System.ComponentModel.Design;

public class ActivityManager {

    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilienc. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    ListingActivity listing = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    
    private int _breathingLog = 0;
    private int _reflectingLog = 0;
    private int _listingLog = 0;
    
    public void Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. start listing activity");
        Console.WriteLine("4. Show me how many times I did each activity");
        Console.WriteLine("5. quit");
        Console.WriteLine("Select a number from the menu:");
    }

    public void ShowMenu()
    {
        Menu();
        int userInput = int.Parse(Console.ReadLine());

          while (userInput != 5)
        {
            if (userInput == 1)
            {
                Console.WriteLine("");
                breathing.StartMessage();
                breathing.run();
                breathing.EndMessage();
                Console.WriteLine("");
                _breathingLog ++;
            }
            else if (userInput == 2)
            {
                Console.WriteLine("");
                reflecting.StartMessage();
                reflecting.run();
                reflecting.EndMessage();
                Console.WriteLine("");
                _reflectingLog ++;
            }
            else if (userInput == 3)
            {
                Console.WriteLine("");
                listing.StartMessage();
                listing.run();
                listing.EndMessage();
                Console.WriteLine("");
                _listingLog ++;
            }
            else if (userInput == 4)
            {

                Console.WriteLine("");
                Console.WriteLine($"You participated in the Breathing Activity {_breathingLog} times.");
                Console.WriteLine($"You participated in the Reflecting Activity {_reflectingLog} times.");
                Console.WriteLine($"You participated in the Listing Activity {_listingLog} times.");
                Console.WriteLine("");
            }
            else {
                Console.WriteLine("you did not enter a number listed in the menu, try again");
            } 
            ShowMenu();
            break;
        }
    }
}

