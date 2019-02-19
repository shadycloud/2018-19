import java.awt.*;
// Created by Shae Cloud 2_18_19

// Data Structures Project 3
public class Circle {
    // Instance variables
    private int xCenter;
    private int yCenter;
    private int radius;
    private int red;
    private int green;
    private int blue;

    /**
     * The <code>Circle</code> constructor creates instances of circle
     * objects with a given center.
     *
     * @param xCenter x coordinate for the center of circle
     * @param yCenter y coordinate for the center of circle
     */
    public Circle(int xCenter, int yCenter) {
        this.xCenter = xCenter;
        this.yCenter = yCenter;
        this.radius = (int) (100 * Math.random());
        this.red = (int) (256 * Math.random());
        this.green = (int) (256 * Math.random());
        this.blue = (int) (256 * Math.random());
    }

    /**
     * A draw(Graphic) method uses Graphic object as an argument to draw itself.
     *
     * @param g is the graphics object it draws with.
     */
    public void draw(Graphics g) {
        System.out.println("Drawing circle with radius " + radius +
                " at the following coordinates: (" + xCenter +
                ", " + yCenter + ")");
        g.fillOval(xCenter - radius, yCenter - radius,
                radius * 2, radius * 2);
        g.setColor(new Color(red, green, blue));
    }

    // Variables used for drawing random circles and connecting dots.
    public int getX() {
        return xCenter;
    }

    public int getY() {
        return yCenter;
    }
}
