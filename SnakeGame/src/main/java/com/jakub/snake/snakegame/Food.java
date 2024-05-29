package com.jakub.snake.snakegame;

import java.awt.*;
import java.util.LinkedList;
import java.util.Random;

public class Food {
    private Point position;
    private Random random;
    private int borderWidth;
    private int borderHight;
    boolean colidesWithSnake;
    boolean colidesWithObstacle;
    boolean valid;
    public Food(int borderWidth, int borderHight) {
        this.borderWidth = borderWidth;
        this.borderHight = borderHight;
        random = new Random();
    }

    public void move(Snake snake, LinkedList<Obstacle> obstacles) {
        valid = false;
        while (!valid) {
            position = generateNewPositon();
            colidesWithSnake = snake.getBody().contains(position);
            colidesWithObstacle = false;
            for (Obstacle obstacle : obstacles ) {
                if (obstacle.getLocation().equals(position)) {
                    colidesWithObstacle = true;
                    break;
                }
            }
            valid = !colidesWithSnake && !colidesWithObstacle;
        }
    }

    private Point generateNewPositon() {
        return new Point(random.nextInt(borderWidth/20),random.nextInt(borderHight/20));
    }

    public Point getPosition() {
        return position;
    }
}
