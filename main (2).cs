using System;

class Program {
  static void Main()
  {
    Console.WriteLine("Enter a number between 1 and 10,000: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number) && number >= 1 && number <= 10000)
    {
      if (IsPrime(number))
      {
        Console.WriteLine($"{number} is a perfect number.");
        }
      else
      {
        Console.WriteLine($"{number} is not a perfect number.");
        }
      }
    else
    {
      Console.WriteLine("Invalid input. Please enter a number between 1 and 10,000.");
      }
    }
  static bool IsPrime(int number)
  {
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
      if (number % i == 0)
      {
        sum += i;
        }
      }
    return sum == number;
    }
  }
    

   