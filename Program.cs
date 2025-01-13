// See https://aka.ms/new-console-template for more information
using System;

class mainProgram
{
    static void Main()
    {
        Console.WriteLine("C# Alarm Clock Project by @cyiver_t");
    }
}

class clockProgram 
{    
    public void displayMenu()
    {
        Console.WriteLine("1. Set Alarm");
        Console.WriteLine("2. Set Timer");
        Console.WriteLine("3. Exit");
        
    }
    public void displayCurrentTime()
    {
        DateTime currentTime = DateTime.Now; // this line of code will grab the curren time from the os
        Console.WriteLine("Current Time: " + currentTime); // this line of code will display the current time
    }

}

