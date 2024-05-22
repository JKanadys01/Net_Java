package org.example;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class ProblemTest {
    @Test
    public void testAtLeastOneItemFits() {
        Problem problem = new Problem(5,123,1,10);
        Result result = problem.solve(20);
        assertTrue(result.itemsInKnapsack.size() > 0);
    }

    @Test
    public void testNoItemFits(){
        Problem problem = new Problem(5,123,11,15);
        Result result = problem.solve(5);
        assertEquals(0,result.itemsInKnapsack.size());
    }

    @Test
    public void testItemsWithinRange(){
        Problem problem = new Problem(5,123,1,10);
        Result result = problem.solve(5);
        for (Item item : problem.items){
            assertTrue(item.weight >= 1 && item.weight <= 10);
            assertTrue(item.value >= 1 && item.value <= 10);
        }
    }

    @Test
    public void testSolutionCorrectness(){
        Problem problem = new Problem(5,123,1,10);
        Result result = problem.solve(20);

        int expectedWeightSum = 0;
        int expectedValueSUm = 0;
        for(int itemIndex : result.itemsInKnapsack){
            expectedWeightSum += problem.items.get(itemIndex).weight;
            expectedValueSUm += problem.items.get(itemIndex).value;
        }
        assertEquals(expectedWeightSum,result.totalWeight);
        assertEquals(expectedValueSUm,result.totalValue);
    }

}