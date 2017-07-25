using System;

namespace Treehouse.FitnessFrog
{
  class Program
  {
    static void Main()
    {
      
      var runningTotal = 0.0;
      
      while (true) 
      {
        // Propmt the user for minutes exercised
        Console.Write("Enter how many minutes you exercised or type \"quit\" to exit:");
        
        var entry = Console.ReadLine();
        if (entry.ToLower() == "quit") 
        {
          break;

        }
        
        try
        {
          var minutes = double.Parse(entry);
          if (minutes <= 0)
          {
            
            Console.WriteLine(minutes + " is not an acceptable value. Try again.");
            continue;
                            
          }
          if (minutes <= 10)
          {
            Console.WriteLine("Better than nothing, I'm I right?");
          }
          else if (minutes <= 30)
          {
            Console.WriteLine("Way to go, hot stuff!");
          }
          else if (minutes <= 60)
          {
            Console.WriteLine("You must be a ninja warrior in training!");
          }
          else 
          {
            Console.WriteLine("Now you're just showing off!");
          } 
          // Add minutes exercised to total
          runningTotal += minutes;
          // Display total minutes exercised to the screen   
          Console.WriteLine("You've entered " + entry +  " minutes");
          Console.WriteLine("Your total is " + runningTotal);
          // Repeat until the user quits
        }
        
        catch (FormatException)
        {
          Console.WriteLine("Not vaild input. Please type a number.");
          continue;
        }
      }
        
    Console.WriteLine("Goodbye!");
    }
  }
}