package com.jakub.snake.snakegame;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Game {
    private Snake snake;
    private LinkedList<Obstacle> obstacles;
    private Food food;
    private boolean justAteFood;
    int score;
    private int width;
    private int height;
    private int numberOfObstacles;
    private boolean movingFood;
    private boolean movingObstacle;
    private boolean gamerunning;

    public Game(int width, int height, boolean movingFood, boolean movingObstacle, int numberOfObstacles) {
        this.width = width;
        this.height = height;
        this.movingFood = movingFood;
        this.movingObstacle = movingObstacle;
        this.numberOfObstacles = numberOfObstacles;
        snake = new Snake(width, height);
        obstacles = new LinkedList<>();
        for (int i = 0; i < numberOfObstacles; i++) {
            obstacles.add(new Obstacle(width,height));
        }
        gamerunning = true;
        score = 0;
        justAteFood = false;
        food = new Food(width,height);
        food.move(snake, obstacles);

    }

    public void update() {
        if (gamerunning) {
            snake.move();
            checkCollisions();
        }
    }

    public void checkCollisions(){
        if (snake.getHead().equals(food.getPosition())) {
            score++;
            snake.grow();
            food.move(snake,obstacles);
            justAteFood = true;
        }

        for (Obstacle obstacle : obstacles) {
            if (snake.getHead().equals(obstacle.getLocation())) {
                gamerunning = false;
            }
        }

        if(!justAteFood && snake.collidesWithItself()) {
            gamerunning = false;
        }
        justAteFood = false;
    }
    public Snake getSnake() {
        return snake;
    }

    public Food getFood() {
        return food;
    }

    public LinkedList<Obstacle> getObstacles() {
        return obstacles;
    }

    public boolean isrunnning() {
        return gamerunning;
    }

    public int getScore() {
        return score;
    }

    public int getWidth() {
        return width;
    }

    public int getHeight() {
        return height;
    }

    public boolean ismovingFood() {
        return movingFood;
    }

    public boolean ismovingObstacle() {
        return movingObstacle;
    }

    public int getNumberOfObstacles() {
        return numberOfObstacles;
    }
}
