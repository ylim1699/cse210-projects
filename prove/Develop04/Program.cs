using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {        
        ActivityManager menu = new ActivityManager();

        menu.showMenu();
        int userInput = int.Parse(Console.ReadLine());

        while (userInput != 4)
        {
            if (userInput == 1)
            {
                
            }
            else if (userInput == 2)
            {
                
            }
            else if (userInput == 3)
            {

            }
            else {
                Console.WriteLine("you did not enter a number listed in the menu, try again");
            }
            menu.showMenu();
        }

    }
}
       
       
       
       
       
       
        // https://wireframe.cc/uFgsH3