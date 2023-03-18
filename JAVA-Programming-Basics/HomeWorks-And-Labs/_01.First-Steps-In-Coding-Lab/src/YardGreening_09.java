import java.util.Scanner;

public class YardGreening_09 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double sqMeters = Double.parseDouble(scan.nextLine());

        double priceSqMeter = 7.61;
        double totalPrice = sqMeters * priceSqMeter;
        double discount = totalPrice * 0.18;

        double finalPrice = totalPrice - discount;

        System.out.printf("The final price is: %f lv.%n", finalPrice);
        System.out.printf("The discount is: %f lv.", discount);
    }
}
