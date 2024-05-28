package com.jakub.snake.snakegame;

import java.util.ArrayList;
import java.util.List;

public class Game {
    private Snake snake;
    private Food food;
    private List<Obstacle> obstacles;
    private boolean justAteFood;
    int score;

    private boolean gamerunning;
    public Game() {
        snake = new Snake();
        food = new Food();
        obstacles = new ArrayList<>();
        gamerunning = true;
        score = 0;
        justAteFood = false;
        for (int i = 0; i < 5; i++) {
            obstacles.add(new Obstacle());
        }
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
            food.move(snake);
            //GameLogger.log("Food eaten, score: " + score);
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

    public List<Obstacle> getObstacles() {
        return obstacles;
    }

    public boolean isrunnning() {
        return gamerunning;
    }

    public int getScore() {
        return score;
    }
}
