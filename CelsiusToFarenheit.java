import java.util.Scanner;

public class CelsiusToFarenheit {
  public static void main(String[] args) {
    // Create a Scanner object to read input from the user
    Scanner scanner = new Scanner(System.in);

    // Prompt the user to enter a temperature in Celsius
    System.out.print("Enter a temperature in Celsius: ");
    double celsius = scanner.nextDouble();

    // Convert Celsius to Fahrenheit using the formula
    double fahrenheit = (celsius * 9.0/5) + 32;

    // Display the result
    System.out.printf("Temerature in Fahrenheit: %.2f", fahrenheit);

    // Close the scanner
    scanner.close();

  }
    


}