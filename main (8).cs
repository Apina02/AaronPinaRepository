using System;

class Program {
  public static void Main (string[] args)
  {
    // Stimulate the previous year's contestant count (this would be input in a real scenario)
    int previousYearContestants = 10;

    // Display menu options to the user
    Console.WriteLine("Welcome to Greenville Idol!");
    Console.WriteLine("Enter the number of contestants for this year (between 0 and 30):");

    // Prompt for the current year's contestants, ensuring it's within valid range
    int currentYearContestants = GetValidContestantCount();

    // Compare the number of contestants and display a message accoridingly
    CompareContestants(previousYearContestants, currentYearContestants);
    }

  // Function to get a valid number of contestants between 0 and 30
  static int GetValidContestantCount()
  {
    int contestantCount = 0; // Initialize the variable
    bool validInput = false;

    while (!validInput)
    {
      // Try to get a valid number from the user
      string input = Console.ReadLine();
      validInput = int.TryParse(input, out contestantCount);

      // Check if the input is within valid range
      if (validInput && (contestantCount >= 0 && contestantCount <= 30))
      {
        return contestantCount;
        }
      else
      {
        // if the input is invalid, prompt the user again
        Console.WriteLine("Invalid input. Please enter a number between 0 and 30:");
        validInput = false;
        }
      }

    return contestantCount;
    }
 
  // Function to compare the number of contestants and display a message accordingly
  static void CompareContestants(int previousYear, int currentYear)
  {
    if (currentYear > previousYear * 2)
    {
      Console.WriteLine("The competition is more than twice as big this year!");
      }
    else if (currentYear > previousYear)
    {
      Console.WriteLine("The competition is bigger than ever!");
      }
    else
    {
      Console.WriteLine("A tighter race this year! Come out and cast your vote!");
  
    }
    }
  
  }
  
      
      
    
  


  
