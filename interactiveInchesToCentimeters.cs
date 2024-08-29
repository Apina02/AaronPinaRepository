using System;

class Program {
  public static void Main (string[] args)
  {

    // Prompt the user to enter a number
    const double CENTIMETERS_PER_INCH = 2.54;

    Console.Write("Enter a number in inches: ");
    string input = Console.ReadLine();

    // Convert the input string to a double
    if (double.TryParse(input, out double inches))
    {
      double centimeters = inches * CENTIMETERS_PER_INCH;
      Console.WriteLine("{0} inches is equal to {1} centimeters.", inches, centimeters);
    }
    else 
    {
      Console.WriteLine("Invalid input. Please enter a valid number.");
    }
    }
    }