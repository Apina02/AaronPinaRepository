import java.util.Scanner;
import java.util.HashSet;

public class Main {

  public static int[] eliminateDuplicates(int[] list) {
    // Use a HashSet to eliminate duplicates
    HashSet<Integer> set = new HashSet<>(); 
    for (int num : list) {
      set.add(num);
    }

    // Convert the HashSet back to an array
    int[] result = new int[set.size()];
    int index = 0;
    for (int num : set) {
      result[index++] = num;
    }

    return result;
  }

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    System.out.print("Enter ten numbers: ");
  
    int[] numbers = new int[10];
    for (int i = 0; i < 10; i++) {
      numbers[i] = scanner.nextInt();
    }

    int[] distinctNumbers = eliminateDuplicates(numbers);

    System.out.print("The distinct numbers are: ");
    for (int num : distinctNumbers) {
      System.out.print(num + " ");
    }
    }
    
  }
  

    
  

  
