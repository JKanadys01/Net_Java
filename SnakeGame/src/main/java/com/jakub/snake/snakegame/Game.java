package com.jakub.snake.snakegame;

public class Game {
    private Snake snake;
    private Food food;
    private boolean justAteFood;
    int score;

    private boolean gamerunning;
    public Game() {
        snake = new Snake();
        food = new Food();
        gamerunning = true;
        score = 0;
        justAteFood = false;
    }

    public void start() {
        GameLogger.log("Game start");
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
            food.move();
            GameLogger.log("Food eaten, score: " + score);
            justAteFood = true;
        }
        if(!justAteFood && snake.collidesWithItself()) {
            gamerunning = false;
            GameLogger.log("Game Over! Snake collided with itself.");
        }
        justAteFood = false;
    }
    public Snake getSnake() {
        return snake;
    }

    public Food getFood() {
        return food;
    }

    public boolean isrunnning() {
        return gamerunning;
    }

    public int getScore() {
        return score;
    }
}
