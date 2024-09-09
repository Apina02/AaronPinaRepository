

import java.util.Scanner;

public class Main {
  
  public static void main(String[] args) {
  Scanner scanner = new Scanner(System.in);

    System.out.print("Enter the month (1-12): ");
    int month = scanner.nextInt();

    System.out.print("Enter the year: ");
    int year = scanner.nextInt();

    int days = getDaysInMonth(month, year);

    if (days != -1) {
      System.out.printf("%d %d has %d days%n", month, year, days);
    } else {
      System.out.println("Invalid month. Please enter a month between 1 and 12.");
    }

    scanner.close();
  }
  public static boolean isLeapYear(int year) {
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
  }
  public static int getDaysInMonth(int month, int year) {
    switch (month) {
      case 1: case 3: case 5: case 7: case 8: case 10: case 12:
        return 31;
      case 4: case 6: case 9: case 11:
        return 30;
      case 2:
        return isLeapYear(year) ? 29 : 28;
      default:
        return -1; // Invalid month
   
 }
  }
  
    }
  