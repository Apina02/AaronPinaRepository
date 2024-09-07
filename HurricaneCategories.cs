using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.Write("Enter the wind speed of the hurricane (in miles per hour): ");

    // Read user input
    string input = Console.ReadLine();
    double windSpeed;

    // Attempt to parse the input
    if (double.TryParse(input, out windSpeed))
    {
      // Classify and output the hurricane category
      string category = ClassifyHurricane(windSpeed);
      Console.WriteLine($"The hurricane is classified as: {category}");
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a numeric wind speed.");
    }
    }
  static string ClassifyHurricane(double windSpeed)
  {
    if (windSpeed >= 157)
    return "Category 5";
    else if (windSpeed >= 130)
    return "Category 4";
    else if (windSpeed >= 111)
    return "Category 3";
    else if (windSpeed >= 96)
    return "Category 2";
    else if (windSpeed >= 74)
    return "Category 1";
    else
    return "Not a hurricane";
  }
    
  }
