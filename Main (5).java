

public class Main {
  public static void main(String[] args) {
    double currentTuition = 10000; // current tuition
    double increaseRate = 0.05; // 5% increase
    int years = 10; // number of years to calculate

    // Calculate tuition in ten years
    double futureTuition = currentTuition * Math.pow(1 + increaseRate, years);
    System.out.printf("Tuition in ten years: $%.2f\n", futureTuition);

    // Calculate total cost of four years' worth of tutition after the tenth year
    double totalCostFourYears = futureTuition * 4;
    System.out.printf("Total cost for four years after the tenth year: $%.2f\n", totalCostFourYears);
    
    
  }

  
}