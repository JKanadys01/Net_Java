package org.example;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Knapsack_GUI extends JFrame {
    private JTextField NrOfItemstextField;
    private JTextField SeedtextField;
    private JTextField CapacitytextField;
    private JTextArea SolutiontextArea;
    private JTextArea ProblemtextArea;
    private JPanel mainPanel;
    private JButton Calculatebutton;

    int numberOfItems = 10;
    int seed = 1;
    int lowerBound = 1;
    int upperBound = 10;
    int capacity = 50;
    public Knapsack_GUI() {
        setContentPane(mainPanel);
        setTitle("Knapsack Problem");
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(600, 400);
        setLocationRelativeTo(null);
        setVisible(true);
        Calculatebutton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (NrOfItemstextField.getText().length() != 0 && SeedtextField.getText().length() != 0 && CapacitytextField.getText().length() != 0) {
                    numberOfItems = Integer.parseInt(NrOfItemstextField.getText());
                    seed = Integer.parseInt(SeedtextField.getText());
                    capacity = Integer.parseInt(CapacitytextField.getText());
                    Problem problem = new Problem(numberOfItems, seed, lowerBound, upperBound);
                    ProblemtextArea.append("Wygenerowany problem:\n" + problem.toString());
                    Result result = problem.solve(capacity);
                    ProblemtextArea.append("\nPosortowany problem:\n" + problem.toString());
                    SolutiontextArea.append(result.toString());

                } else
                    JOptionPane.showMessageDialog(mainPanel, "Please enter all the items in the textfield");

            }
        });
    }

    public static void main(String[] args) {
        new Knapsack_GUI();
    }
}
