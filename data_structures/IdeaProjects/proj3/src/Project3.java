import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;
// Created by Shae Cloud 2_18_19

// Data Structures Project 3
public class Project3 {

    private JFrame frame;
    private boolean tracking;
    private boolean drawCircles;
    private int xstart;
    private int ystart;
    private int xend;
    private int yend;
    private int borderWidth = 5;
    ArrayList<Circle> circles = new ArrayList<>();

    /**
     * Main method. Creates a new Project3 object.
     * All the heavy work is done in the constructor.
     *
     * @param args Not used.
     */
    public static void main(String[] args) {
        Project3 first = new Project3();
    }//main

    public Project3() {
        tracking = false;
        drawCircles = true;
        frame = new JFrame();
        frame.setBounds(250, 98, 600, 480);
        frame.setTitle("Window number three");
        Container cp = frame.getContentPane();

        // Erases drawing area when clicked.
        JButton clear = new JButton("Clear Form");
        clear.addActionListener(e -> {
            circles.clear();
            frame.repaint();
        });

        // Tracks mouse movement button.
        JButton track = new JButton("Track Mouse");
        track.addActionListener(ae -> trackMouse());

        // Radio buttons switch between random circles and dot connecting modes.
        JRadioButton drawCirclesButton = new JRadioButton("Draw Circles");
        JRadioButton connectDotsButton = new JRadioButton("Connect Dots");
        drawCirclesButton.setSelected(true);
        drawCirclesButton.addActionListener(ae -> {
            // Initiating of circle button is critical to program functionality.
            drawCircles = true;
            circles.clear();
            frame.repaint();
        });

        // On selection: change the mode to drawing lines, clear the list of
        // circles, and the refresh the frame.
        connectDotsButton.addActionListener(ae -> {
            drawCircles = false;
            circles.clear();
            frame.repaint();
        });

        // Button group to keep only one toggled at a time.
        ButtonGroup gRadio = new ButtonGroup();
        gRadio.add(drawCirclesButton);
        gRadio.add(connectDotsButton);
        JPanel top = new JPanel();
        top.add(drawCirclesButton);
        top.add(connectDotsButton);
        top.add(track);
        top.add(clear);
        cp.add(top, BorderLayout.NORTH);
        MyPanel pane = new MyPanel();
        cp.add(pane, BorderLayout.CENTER);

        // Circle object created with (x,y), and then stored into array list.
        pane.addMouseListener(new MouseAdapter() {
            public void mousePressed(MouseEvent e) {
                xstart = e.getX();
                ystart = e.getY();
                Circle circle = new Circle(xstart, ystart);
                circles.add(circle);
            }

            // Circle is only created when pressed values are equal to released.
            public void mouseReleased(MouseEvent e) {
                xend = e.getX();
                yend = e.getY();
                frame.repaint();
            }
        });
        // Creates human readable mouse tracking values.
        pane.addMouseMotionListener(new MouseMotionAdapter() {
            public void mouseMoved(MouseEvent e) {
                if (tracking) {
                    int x = e.getX();
                    int y = e.getY();
                    msg("(" + x + ", " + y + ")");
                }
            }
        });
        frame.setVisible(true);
    }//constructor

    public void trackMouse() {
        tracking = !tracking;
    }//trackMouse

    public void msg(String s) {
        System.out.println(s);
    }

    // MyPanel extends the JPanel class to include modified functionality.
    class MyPanel extends JPanel {
        // paintComponent() method calls the draw method for each Circle object.
        public void paintComponent(Graphics g) {
            int width = this.getWidth();
            int height = this.getHeight();
            msg("H = " + height + ",  w = " + width);
            g.setColor(Color.BLACK);
            for (int delta = 0; delta < borderWidth; delta++) {
                g.drawRect(delta, delta, width - (2 * delta),
                        height - (2 * delta));
            }
            // When a click is detected, a circle object is created.
            if (xstart == xend || ystart == yend) {
                for (int i = 0; i < circles.size(); i++) {
                    Circle c = circles.get(i);
                    // Calls draw method if radio button is selected.
                    if (drawCircles) {
                        c.draw(g);
                    } else {
                        // Using same (x,y) for line drawing functionality.
                        if (i > 0) {
                            Circle nextToLast = circles.get(i - 1);
                            g.drawLine(c.getX(), c.getY(), nextToLast.getX(),
                                    nextToLast.getY());
                        }
                    }
                }
            }
        }
    }
}



