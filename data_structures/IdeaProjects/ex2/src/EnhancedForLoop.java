import java.util.Scanner;

public class EnhancedForLoop {
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);

        int[] someNumbers = {0, 1, 3, 4, 5};

        for (int number : someNumbers) {
            System.out.println(number);
            System.out.println("Press Enter to continue...");
            keyboard.nextLine();
        }

        for (int i = 0; i < someNumbers.length; i++) {
            System.out.println(someNumbers[0]);
            System.out.println("Press Enter to continue...");
            keyboard.nextLine();
        }

    }
}
