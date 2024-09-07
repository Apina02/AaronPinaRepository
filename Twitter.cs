using System;

class Twitter {
  public static void Main (string[] args) {
    // Prompt user to enter a message 
    Console.WriteLine("Enter a message: ");
    string message = Console.ReadLine();

    // Define the maxixmum length allowed
    const int MAX_LENGTH = 140;

    // Check the length of the message
    if (message.Length <= MAX_LENGTH)
    {
      Console.WriteLine("Posted");
      }
    else
    {
      Console.WriteLine("Rejected");
  
    }
      
    }
  }
