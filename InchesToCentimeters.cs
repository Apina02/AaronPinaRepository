using System;

class Program {
  public static void Main (string[] args) 
  {
    const double CENTIMETERS_PER_INCH = 2.54;
    
    double inches = 15994;
    double centimeters = inches * CENTIMETERS_PER_INCH;
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
    
  }
  }
