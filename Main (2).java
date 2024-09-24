import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    // Create a Scanner object to read input
    Scanner scanner = new Scanner(System.in);

    // Prompt the user to enter the side length
    System.out.print("Enter the side: ");
    double side = scanner.nextDouble();

    // Calculate the area using the formula (3 * sqrt(3) / 2) * side^2)
    double area = (3 * Math.sqrt(3) / 2) * Math.pow(side, 2);

    // Display the area 
    System.out.printf("The area of the hexagon is %.2f%n", area);

    // Close the scanner 
    scanner.close();
    
  }

  
}