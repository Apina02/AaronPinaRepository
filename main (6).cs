using System;

class Program
{
  // Method to display the Greenville motto
  static void DisplayMotto()
  {
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville.  *");
    Console.WriteLine("************************************");
    }

  // Method to display the menu options
  static void DisplayMenu()
  {
    Console.WriteLine("Please Enter the following number below from the following menu:\n");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit\n");
    }

  // Methos to calculate revenue and compare contestants
  static void CalculateRevenue()
  {
    try
    {
      // Get input for last year's and this year's contestant numbers
      Console.Write("Enter the number of contestants from last year");
      int lastYear = int.Parse(Console.ReadLine());

      Console.Write("Enter the number of contestants from this year");
      int currentYear = int.Parse(Console.ReadLine());

      // Calculate revenue for this year
      int ticketPrice = 25;
      int revenueThisYear = currentYear = currentYear * ticketPrice;

      // Display the results
      Console.WriteLine($"\nLast year's competition had {lastYear} contestants, and this year's has {currentYear} contestants.");
      Console.WriteLine($"\nRevenue expected this year is ${revenueThisYear}");

      // Compare if this year's competition is bigger
      if (currentYear > lastYear)
      {
        Console.WriteLine("It is true that this year's competition is bigger than last year's.");
        }
      else
      {
        Console.WriteLine("This year's competition is not bigger than last year's.");
        }
      }
    catch (FormatException)
    {
      Console.WriteLine("Please enter valid numbers for the contestants.\n");
      }
    }

  // Method to exit the program
  static void ExitProgram()
  {
    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    }

  // Main method 
  static void Main(string[] args)
  {
    // Display motto at the start
    DisplayMotto();

    bool running = true;
    while (running)
    {
      // Display menu options
      DisplayMenu();

      //Get user input for the menu option
      string choice = Console.ReadLine();

      switch (choice)
      {
      case "1":
        CalculateRevenue();
        break;
      case "2":
        ExitProgram();
        running = false;
        break;
      default:
        Console.WriteLine("Invalid input, please select a valid option from the menu.\n");
        break;
        
      }


    }
  }
  
    }
      
      
    
  

    
  
  
