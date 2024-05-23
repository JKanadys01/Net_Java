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

    public boolean isrunnning() {
        return gamerunning;
    }

    public int getScore() {
        return score;
    }
}
