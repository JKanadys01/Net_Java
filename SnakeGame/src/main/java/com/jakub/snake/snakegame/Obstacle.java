package com.jakub.snake.snakegame;

import java.awt.*;
import java.util.Random;

public class Obstacle {
    private Point location;
    private Random rand;

    public Obstacle() {
        rand = new Random();
        location = generateNewLocation();
    }

    public void move() {
        location = generateNewLocation();
    }

    private  Point generateNewLocation() {
        return new Point(rand.nextInt(20), rand.nextInt(20));
    }

    public Point getLocation() {
        return location;
    }
}
