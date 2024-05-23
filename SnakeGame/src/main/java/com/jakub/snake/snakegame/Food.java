package com.jakub.snake.snakegame;

import java.awt.*;
import java.util.Random;

public class Food {
    private Point position;
    private Random random;
    public Food() {
        random = new Random();
        position = generateNewPositon();
    }

    public void move(Snake snake) {
        boolean valid = false;
        while (!valid) {
            position = generateNewPositon();
            valid = !snake.getBody().contains(position);
        }
    }

    private Point generateNewPositon() {
        return new Point(random.nextInt(20),random.nextInt(20));
    }

    public Point getPosition() {
        return position;
    }
}
