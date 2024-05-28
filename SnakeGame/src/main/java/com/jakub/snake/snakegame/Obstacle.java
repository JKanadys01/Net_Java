package com.jakub.snake.snakegame;

import java.awt.*;
import java.util.Random;

public class Obstacle {
    private Point location;
    private Random rand;
    private int borderWidth;
    private int borderHight;

    public Obstacle(int borderWidth, int borderHight) {
        this.borderWidth = borderWidth;
        this.borderHight = borderHight;
        rand = new Random();
        location = generateNewLocation();
    }

    public void move() {
        location = generateNewLocation();
    }

    private  Point generateNewLocation() {
        return new Point(rand.nextInt(borderWidth/20), rand.nextInt(borderWidth/20));
    }

    public Point getLocation() {
        return location;
    }
}
