package org.example;

import java.util.List;

public class Result {
    List<Integer> itemsInKnapsack;
    int totalValue;
    int totalWeight;

    public Result(List<Integer> itemsInKnapsack, int totalValue, int totalWeight) {
        this.itemsInKnapsack = itemsInKnapsack;
        this.totalValue = totalValue;
        this.totalWeight = totalWeight;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("Items in the knapsack:");
        for (int i : itemsInKnapsack) {
            result.append(i).append(" ");
        }
        result.append("\nTotal value: ").append(totalValue);
        result.append("\nTotal weight: ").append(totalWeight);
        return result.toString();
    }
}
