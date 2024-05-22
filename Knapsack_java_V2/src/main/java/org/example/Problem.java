package org.example;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;

public class Problem {
    private int numItems;
    private int seed;
    private int lowerBound;
    private int upperBound;
    public List<Item> items;

    public Problem(int numItems, int seed, int loverBound, int upperBound) {
        this.numItems = numItems;
        this.seed = seed;
        this.lowerBound = loverBound;
        this.upperBound = upperBound;
        this.items = new ArrayList<Item>();
        generateItems();
    }

    private void generateItems() {
        Random rand = new Random(seed);
        for (int i = 0; i < numItems; i++) {
            int value = rand.nextInt(upperBound - lowerBound) + lowerBound;
            int weight = rand.nextInt(upperBound - lowerBound) + lowerBound;
            items.add(new Item(value, weight));
        }
    }


    public Result solve(int capacity) {
        List<Integer> selectedItems = new ArrayList<>();
        int totalWeight = 0;
        int totalValue = 0;
        int currentItemInex = 0;
        Collections.sort(items, (a, b) -> Double.compare((double)b.value / b.weight, (double)a.value / a.weight));

        for (Item item : items) {
            while(totalWeight + item.weight <= capacity) {
                totalWeight += item.weight;
                totalValue += item.value;
                selectedItems.add(currentItemInex);
            }
            currentItemInex++;
        }
        return new Result(selectedItems, totalValue, totalWeight);
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Number of items: ").append(numItems);
        sb.append("\nSeed value: ").append(seed);
        sb.append("\nLover bound: ").append(lowerBound);
        sb.append("\nUpper bound: ").append(upperBound);
        sb.append("\n");
        for (int i = 0; i < numItems; i++) {
            sb.append("Item: ").append(i).append(": Value = ").append(items.get(i).value).append(": Weight = ").append(items.get(i).weight).append("\n");
        }
        return sb.toString();
    }
}
