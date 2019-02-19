import javax.swing.*;
import java.io.File;
import java.io.FileNotFoundException;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Scanner;

@SuppressWarnings("Duplicates")
public class Num {
    public static void main(String[] args) throws FileNotFoundException {
        int count = 0;
        double min = Double.POSITIVE_INFINITY; // To ensure greater than all real values
        double max = -1.0; // Richter scale starts at 0 so -1 is less than all real values
        int numMaxTies = 1;
        int numMinTies = 1;
        double magTotal = 0;

        JFileChooser fc = new JFileChooser();
        fc.setCurrentDirectory(new File(System.getProperty("user.dir")));
        fc.showOpenDialog(null);
        Scanner scanner = new Scanner(fc.getSelectedFile());
        DecimalFormat gor = new DecimalFormat(".##");
        DecimalFormat gor2 = new DecimalFormat("");

        ArrayList<String> maxLocations = new ArrayList<>();
        ArrayList<String> maxDates = new ArrayList<>();
        ArrayList<String> minLocations = new ArrayList<>();
        ArrayList<String> minDates = new ArrayList<>();

        while (scanner.hasNextLine()) {
            count = count + 1; // same as count++
            scanner.useDelimiter(",");
            double mag = scanner.nextDouble();

            String[] locationAndDate = scanner.nextLine().replaceFirst(",\"", "").split("\"*,*\"");

            magTotal = mag + magTotal;
            if (max < mag) {
                maxLocations.clear();
                maxDates.clear();
                max = mag;
                numMaxTies = 1;
                maxLocations.add(locationAndDate[0]);
                maxLocations.add(locationAndDate[1]);
            } else if (mag == max) {
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
        System.out.println("\n\n" +
                "##QUAKE####REPORT###############################################\n" +
                "The maximum magnitude value, " + max + " was detected in " + gor2.format(numMaxTies) +
                " instances.\nBeginning with the most recent, below is the list of recorded\n" +
                "locations and their corresponding dates and times:\n" +
                "________________________________________________________________\n" +
                "________________________________________________________________\n\n" + maxLocations + "\n" +
                "################################################################\n\n\n\n" +
                "################################################################\n" +
                "The minimum magnitude value, " + min + " was detected in " + gor2.format(numMinTies) +
                " instances.\nBeginning with the most recent, below is the list of recorded\n" +
                "locations and their corresponding dates and times:\n" +
                "________________________________________________________________\n" +
                "________________________________________________________________\n\n" + minLocations + "\n" +
                "################################################################\n\n" +
                "################################################################\n\n" +
                "The avg of all computed magnitudes: " + gor.format(avg) + "\n" +
                "The total sum of all computed magnitudes: " + gor.format(magTotal));
    }
}
