import java.util.Scanner;
import java.io.*;

public class Ex2 {
    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(new File("/Users/cloud/IdeaProjects/hello/src/com/company/test"));
        int max;
        int min;
        int numMaxTies = 1;
        int numMinTies = 1;

        if (input.hasNext()) {
            int firstNumber = input.nextInt();
            max = firstNumber;
            min = firstNumber;


            while (input.hasNext()) {
                int number = input.nextInt();
                if (number > max) {
                    max = number;
                    numMaxTies = 1;
                } else if (number == max) {
                    numMaxTies++;
                }

                if (number < min) {
                    min = number;
                    numMinTies = 1;
                } else if (number == min) {
                    numMinTies++;
                }
            }

            System.out.println("The max is: " + max + " and it occurred " + numMaxTies + " times.");
            System.out.println("The min is: " + min + " and it occurred " + numMinTies + " times.");
        } else {
            System.out.println("The file was empty...");
        }
    }
}

