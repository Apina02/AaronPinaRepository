import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
   // Create a scanner object for a user input 
    Scanner scanner = new Scanner(System.in);

    // Prompt user to enter weight in pounds
    System.out.print("Enter weight in pounds: ");
    double weight = scanner.nextDouble();

    // Prompt user to enter height in feet
    System.out.print("Enter feet: ");
    int feet = scanner.nextInt();

    // Prompt user to enter height in inches
    System.out.print("Enter inches: ");
    int inches = scanner.nextInt();

    // Convert height to inches 
    int totalInches = feet * 12 + inches;

    // Convert height to meters (1 inch = 0.0254 meters)
    double heigthInMeters = totalInches * 0.0254;

    // Convert weight to kilograms (1 pound = 0.453592 kilograms)
    double weightInKilograms = weight * 0.453592;

    // Calculate BMI
    double bmi = weightInKilograms / (heigthInMeters * heigthInMeters);

    // Print BMI 
    System.out.println("BMI is " + bmi);

    // Interpret the BMI
    if (bmi < 18.5) {
      System.out.println("Underweight");
    } else if (bmi < 25) {
      System.out.println("Normal");
    } else if (bmi < 30) {
      System.out.println("Overweight");
    } else {
      System.out.println("Obesity");
    }

    // Close the scanner
    scanner.close();
    }
    }
  

  
