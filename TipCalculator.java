import java.util.Scanner;

public class TipCalculator {
  public static void main(String[] args) {
    // Create a Scanner object to read input from the user
    Scanner scanner = new Scanner(System.in);

    // Prompt the user to enter the subtotal
    System.out.print("Enter the subtotal: ");
    double subtotal = scanner.nextDouble();

    // Prompt the user to enter the gratuity rate
    System.out.print("Enter the gratuity rate (as a percentage): ");
    double gratuityRate = scanner.nextDouble();

    // Calculate the gratuity and total
    double gratuity = subtotal * (gratuityRate / 100);
    double total = subtotal + gratuity;

    // Display the results
    System.out.printf("Gratuity: $%.2f\n", gratuity);
    System.out.printf("Total: $%.2f\n", total);

    // Close the Scanner object
    scanner.close();
    
  
  }

 
}