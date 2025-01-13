// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;


class mainProgram
{
    static void Main()
    {
        //declaring other classes
        clockProgram clock = new clockProgram();

        Console.WriteLine("C# Alarm Clock Project by @cyiver_t");
        clock.displayCurrentTime();

        // this part will let the user select the option
        while (true)
        {
            clock.displayMenu();
            int userChoice = Convert.ToInt32(Console.ReadLine());
            // Covert.ToInt32 will convert the string to integer. Why? because Console.ReadLine() will return a string.

            switch (userChoice)
            {
                case 1:
                {
                    break;
                }
                case 2:
                {
                    break;
                }
                case 3:
                {
                    Environment.Exit(0);
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid choice");
                    break;
                }
            }
        }
    }
}

class clockProgram 
{    
    // this function will display the menu
    public void displayMenu()
    {
        Console.WriteLine("1. Set Alarm"); 
        Console.WriteLine("2. Set Timer");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Enter your choice: ");
    }

    // this function will display the current time
    public void displayCurrentTime()
    {
        DateTime currentTime = DateTime.Now; // this line of code will grab the curren time from the os
        Console.WriteLine("Current Time: " + currentTime); // this line of code will display the current time
    }

    // this function will play the alarm sound
    public void alarmSound()
    {
        for (int alartRepeat = 0; alartRepeat < 5; alartRepeat++)
        {
            Console.Beep();
        }
    }
}

