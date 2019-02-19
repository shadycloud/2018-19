import javax.swing.*;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
// Created by Shae Cloud 2_2_19

// This program aims to demonstrate a few GUI tricks that can utilized in Java
public class GuiTricks {
    JSlider slider = new JSlider(1990, 2019, 1990);
    JTextField textField = new JTextField("1990", 6);
    JFrame frame;
    JPanel east, north, south;

    public static void main(String[] args) {
        GuiTricks play = new GuiTricks();
    }

    // With a no args constructor, 'super()' will automatically get used which calls the parent constructor
    public GuiTricks() {

        // Creates an instance of the frame
        frame = new JFrame("Cloud Project 2");
        frame.setBounds(184, 91, 700, 488);
        frame.addWindowListener(new WinHandler());
        frame.getContentPane().setBackground(Color.red);


        // Set slider with a change listener to cause an action of textfield population with numeric slider value
        east = new JPanel();
        east.setBackground(Color.red);
        east.add(slider);
        slider.setOrientation(JSlider.VERTICAL);
        slider.setPaintTicks(true);
        slider.setPaintLabels(true);
        slider.setMajorTickSpacing(4);
        slider.setMinorTickSpacing(2);
        slider.addChangeListener(new SliderListener());
        frame.add(east, BorderLayout.EAST);

        // Adds label panel to the north for the text field there
        north = new JPanel();
        north.setBackground(Color.red);
        north.add(new JLabel("Choose Year"));
        north.add(textField);
        frame.add(north, BorderLayout.NORTH);
        textField.addActionListener(new TextListener());

        // Adds Radio button group to toggle background colors
        south = new JPanel();
        south.setBackground(Color.red);
        JRadioButton red = new JRadioButton("red");
        JRadioButton green = new JRadioButton("green");
        JRadioButton blue = new JRadioButton("blue");
        ButtonGroup bgColors = new ButtonGroup();

        // Adds buttons to the group 'bgColors'
        bgColors.add(red);
        bgColors.add(green);
        bgColors.add(blue);

        // Adds buttons to the panel
        south.add(red);
        south.add(green);
        south.add(blue);

        // Adds the radio button listeners with the 'addActionListener' method
        red.addActionListener(new RbListener());
        green.addActionListener(new RbListener());
        blue.addActionListener(new RbListener());

        // Initializes the radio button group with red
        red.setSelected(true);
        frame.add(south, BorderLayout.SOUTH);
        // Makes the frame visible. Last step.
        frame.setVisible(true);
    }

    // The slider value is declared as an int to be displayed with empty string
    class SliderListener implements ChangeListener {

        public void stateChanged(ChangeEvent e) {
            int val = slider.getValue();
            textField.setText("" + val);
        }
    }

    // numText is stored as a string and parsed to be interpreted as an integer
    class TextListener implements ActionListener {

        public void actionPerformed(ActionEvent e) {
            String numText = textField.getText();
            slider.setValue(Integer.parseInt(numText));
        }
    }

    // Action Listeners differ from change, and item listeners each having their own respected objects
    class RbListener implements ActionListener {

        public void actionPerformed(ActionEvent e) {
            JRadioButton button = (JRadioButton) e.getSource();
            if (button.getText().equals("red")) {
                frame.getContentPane().setBackground(Color.red);
                east.setBackground(Color.red);
                north.setBackground(Color.red);
                south.setBackground(Color.red);
            } else if (button.getText().equals("green")) {
                frame.getContentPane().setBackground(Color.green);
                east.setBackground(Color.green);
                north.setBackground(Color.green);
                south.setBackground(Color.green);
            } else if (button.getText().equals("blue")) {
                frame.getContentPane().setBackground(Color.blue);
                east.setBackground(Color.blue);
                north.setBackground(Color.blue);
                south.setBackground(Color.blue);
            }
        }
    }

    class WinHandler extends WindowAdapter {
        // class WinHandler implements WindowListener {
        // Invoked when the Window is set to be the active Window.
        public void windowActivated(WindowEvent e) {
            System.out.println(":>windowActivated");
        }

        // Invoked when a window has been closed as the result of calling dispose on the window.
        public void windowClosed(WindowEvent e) {
            System.out.println(":>windowClosed");
        }

        // Invoked when the user attempts to close the window from the window's system menu.
        public void windowClosing(WindowEvent e) {
            System.out.println(":>windowClosing");
            System.exit(0);
        }

        // Invoked when a Window is no longer the active Window.
        public void windowDeactivated(WindowEvent e) {
            System.out.println(":>windowDeactivated");
        }

        // Invoked when a window is changed from a minimized to a normal state.
        public void windowDeiconified(WindowEvent e) {
            System.out.println(":>windowDeiconified");
        }

        // Invoked when a window is changed from a normal to a minimized state.
        public void windowIconified(WindowEvent e) {
            System.out.println(":>windowIconified");
        }

        // Invoked the first time a window is made visible.
        public void windowOpened(WindowEvent e) {
            System.out.println(":>windowOpened");
        }

    }
}