package com.jakub.snake.snakegame;

import java.awt.*;
import java.util.Random;

public class Obstacle {
    private Point location;
    private Random rand;
    private int borderWidth;
    private int borderHight;
    boolean colidesWithSnake;
    boolean colidesWithFood;
    boolean valid;

    public Obstacle(int borderWidth, int borderHight) {
        this.borderWidth = borderWidth;
        this.borderHight = borderHight;
        rand = new Random();
        location = generateNewLocation();
    }

    public void move(Snake snake, Food food) {
        valid = false;
        while (!valid) {
            location = generateNewLocation();
            colidesWithFood = snake.getBody().contains(location);
            colidesWithSnake = food.getPosition().equals(location);
            valid = !colidesWithFood && !colidesWithSnake;

        }
    }

    private  Point generateNewLocation() {
        return new Point(rand.nextInt(borderWidth/20), rand.nextInt(borderHight/20));
    }

    public Point getLocation() {
        return location;
    }
}
