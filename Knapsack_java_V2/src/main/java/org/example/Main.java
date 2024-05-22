package org.example;

import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter the number of items: ");
        int numberOfItems = sc.nextInt();

        System.out.println("Enter the seed value: ");
        int seed = sc.nextInt();

        System.out.println("Enter the lower bound: ");
        int lowerBound = sc.nextInt();

        System.out.println("Enter the upper bound: ");
        int upperBound = sc.nextInt();

        System.out.println("Enter the capacity: ");
        int capacity = sc.nextInt();

        Problem problem = new Problem(numberOfItems, seed,lowerBound,upperBound);
        System.out.println(("\nGenerated problem:\n"));
        System.out.println(problem);
        Result result = problem.solve(capacity);
        System.out.println(("\nSorted Items:\n"));
        System.out.println(problem);
        System.out.println("\nSolution:\n" + result);

        sc.close();
    }
}