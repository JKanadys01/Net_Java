package com.jakub.snake.snakegame;

import java.awt.*;
import java.util.Random;

public class Food {
    private Point position;
    private Random random;
    private int borderWidth;
    private int borderHight;


    public Food(int borderWidth, int borderHight) {
        this.borderWidth = borderWidth;
        this.borderHight = borderHight;
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
        return new Point(random.nextInt(borderWidth/20),random.nextInt(borderHight/20));
    }

    public Point getPosition() {
        return position;
    }
}
