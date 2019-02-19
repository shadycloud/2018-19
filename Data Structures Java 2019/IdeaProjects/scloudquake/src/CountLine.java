import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.text.DecimalFormat;
import java.util.Scanner;


public class CountLine {

    private static DecimalFormat gor = new DecimalFormat(".##");

    public static void main(String[] args) throws FileNotFoundException {
        int count = 0;                                                                                                  // a.) Variable to count the number of values read
        String filePath = "/Users/cloud/IdeaProjects/scloudquake/.idea/testdata";
        Scanner scanner = new Scanner(new File(filePath));
        double magTotal = 0;                                                                                            // b.) Variable for the sum of the magnitudes
        while (scanner.hasNextLine()) {
            count = count + 1; // same as count++
            scanner.useDelimiter(",");
            double mag = scanner.nextDouble();
            magTotal = mag + magTotal ;
            String line = scanner.nextLine();                                                                           // example of an instance variable
            //System.out.println("<" + mag + "> <" + line + ">");                                                       // testing code for return values
        }
        double avg = count/magTotal;//best place to do the math?
        System.out.println("The avg of all computed magnitudes: " + gor.format(avg) +                                   // c.) the average magnitude value (to 2 decimal places),
                "\nThe total sum of all computed magnitudes: " + gor.format(magTotal) +                                 // b.) the total sum of the magnitudes (to 2 decimal places),
                "\nThe number of computed magnitudes: " + count );                                                      // a.) the count of the number of values read,

    }
}

/* You are to write a Java application that uses data from one of these files and generates a report with:

a.) the count of the number of values read,
b.) the total sum of the magnitudes,
c.) the average magnitude value (to 2 decimal places),
___________________
d.) the maximum magnitude value, where it happened and when
e.) the minimum magnitude value, where it happened and when
f.) The program should work on any file that has all of its data properly formatted, therefore, the program
should prompt the user for the name of the file.

Your program should NOT save all of the data. Just read and process one line at a time.                               */