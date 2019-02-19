import javax.swing.*;
import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Scanner;

@SuppressWarnings("Duplicates")
// Created by Shae Michael Cloud 1_21_19


public class PrintRight {


    public static void main(String[] args) throws IOException {
        int count = 0;
        double min = Double.POSITIVE_INFINITY;
        // To ensure greater than all real values.
        double max = -1.0;
        // Richter scale starts at 0 so -1 is less than all real values.
        int numMaxTies = 1;
        int numMinTies = 1;
        double magTotal = 0;

        JFileChooser fc = new JFileChooser();
        // GUI form for choosing files to be analyzed.
        fc.setCurrentDirectory(new File(System.getProperty("user.dir")));
        // "user.dir" sets directory where java was run from.
        fc.showOpenDialog(null);
        Scanner scanner = new Scanner(fc.getSelectedFile());
        DecimalFormat gor = new DecimalFormat(".##"); // Format of output value to two decimal places.
        // Dynamic array list of string type to store max and min information.
        ArrayList<String> maxLocations = new ArrayList<>();
        ArrayList<String> maxDates = new ArrayList<>();
        ArrayList<String> minLocations = new ArrayList<>();
        ArrayList<String> minDates = new ArrayList<>();

        while (scanner.hasNextLine()) {
            count = count + 1;
            // Same as count++
            scanner.useDelimiter(",");
            double mag = scanner.nextDouble();

            String[] locationAndDate = scanner.nextLine().replaceFirst(",\"", "").split("\"*,*\"");
            // The next 4 blocks of code below will update the array lists with extrema values,
            // location, and date information as program scans through a file
            magTotal = mag + magTotal;
            // Keeping track of the total magnitude values.
            if (max < mag) {
                // Resets location and date with .clear() method before storing new strings into indexes [0] and [1].
                maxLocations.clear();
                maxDates.clear();
                max = mag;
                numMaxTies = 1;
                maxLocations.add(locationAndDate[0]);
                maxLocations.add(locationAndDate[1]);
            } else if (mag == max) {
                // When a tie is evaluated, program adds formatted location and date information to proper array list.
                numMaxTies++;
                maxLocations.add("\n " + locationAndDate[0]);
                maxLocations.add(locationAndDate[1]);
            }
            if (mag < min) {
                minLocations.clear();
                minDates.clear();
                min = mag;
                numMinTies = 1;
                minLocations.add(locationAndDate[0]);
                minLocations.add(locationAndDate[1]);
            } else if (mag == min) {
                numMinTies++;
                minLocations.add("\n " + locationAndDate[0]);
                minLocations.add(locationAndDate[1]);
            }
        } // Finish loop
        double avg = magTotal / count;

        // Print to console
        System.out.println("\n\n" +
                "##QUAKE####REPORT###############################################\n" +
                "The maximum magnitude value, " + max + " was detected in " + numMaxTies +
                " instances.\nBeginning with the most recent, below is the list of recorded\n" +
                "locations and their corresponding dates and times:\n" +
                "________________________________________________________________\n" +
                "________________________________________________________________\n\n" + maxLocations + "\n" +
                "################################################################\n\n\n\n" +
                "################################################################\n" +
                "The minimum magnitude value, " + min + " was detected in " + numMinTies +
                " instances.\nBeginning with the most recent, below is the list of recorded\n" +
                "locations and their corresponding dates and times:\n" +
                "________________________________________________________________\n" +
                "________________________________________________________________\n\n" + minLocations + "\n" +
                "################################################################\n\n" +
                "################################################################\n\n" +
                "The avg of all computed magnitudes: " + gor.format(avg) + "\n" +
                "The total sum of all computed magnitudes: " + gor.format(magTotal));
        // Creates file titled "file.txt" with required information of earthquake report.
        File file = new File("~/Users/cloud/Desktop/file.txt");
        PrintWriter printWriter = new PrintWriter("file.txt");
        printWriter.println(
                "##QUAKE####REPORT###############################################\n" +
                "The maximum magnitude value, " + max + " was detected in " + numMaxTies +
                " instances.\nBeginning with the most recent, below is the list of recorded\n" +
                "locations and their corresponding dates and times:\n" +
                "________________________________________________________________\n" +
                "________________________________________________________________\n\n" + maxLocations + "\n" +
                "################################################################\n\n\n\n" +
                "################################################################\n" +
                "The minimum magnitude value, " + min + " was detected in " + numMinTies +
                " instances.\nBeginning with the most recent, below is the list of recorded\n" +
                "locations and their corresponding dates and times:\n" +
                "________________________________________________________________\n" +
                "________________________________________________________________\n\n" + minLocations + "\n" +
                "################################################################\n\n" +
                "################################################################\n\n" +
                "The avg of all computed magnitudes: " + gor.format(avg) + "\n" +
                "The total sum of all computed magnitudes: " + gor.format(magTotal));

        printWriter.close();
    }
}

