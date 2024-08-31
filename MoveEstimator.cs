using System;

class Program {
  static void Main()
  {
    // Constants for base rate, hourly rate, and per mile rate
    const decimal BASE_RATE = 200m;
    const decimal HOURLY_RATE = 150m;
    const decimal PER_MILE_RATE = 2m;

    // Prompt user for the number of hours and miles
    Console.Write("Enter the number of hours for the move: ");
    string hoursInput = Console.ReadLine();
    decimal hours;
    while (!decimal.TryParse(hoursInput, out hours) || hours < 0)
    {
      Console.Write("Invalid input. Please enter a positive number for hours: ");
      hoursInput = Console.ReadLine();
    }

    Console.Write("Enter the number of miles for the move: ");
    string milesInput = Console.ReadLine();
    decimal miles;
    while (!decimal.TryParse(milesInput, out miles) || miles < 0)
    {
      Console.Write("Invalid input. Please enter a positive number for miles: ");
      milesInput = Console.ReadLine();
    }

    // Calculate total moving fee
    decimal totalFee = BASE_RATE + (hours * HOURLY_RATE) + (miles * PER_MILE_RATE);

    //Display the total moving fee
    Console.WriteLine( $"The total moving fee is: {totalFee:C}");
  }
}