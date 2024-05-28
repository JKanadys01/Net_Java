package com.jakub.snake.snakegame;

public class ThreadManager {
    private Thread foodThread;
    private Thread obstacleThread;
    private Game game;

    public ThreadManager(Game game) {
        this.game = game;
        foodThread = new Thread(this::moveFood);
        obstacleThread = new Thread(this::moveObstacle);
    }

    public void start() {
        if(game.ismovingFood()) {
            foodThread.start();
        }
        if(game.ismovingObstacle()) {
            obstacleThread.start();
        }
    }

    public void stop() {
        foodThread.interrupt(); // Przerywamy wątek jedzenia
    }

    private void moveFood() {
        while (game.isrunnning()) {
            game.getFood().move(game.getSnake());
            try {
                Thread.sleep(5000);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt(); // Przerwanie wątku w przypadku wyjątku
            }
        }
    }

    private void moveObstacle() {
        while (game.isrunnning()) {
            for (Obstacle obstacle : game.getObstacles()) {
                obstacle.move();
            }
            try {
                Thread.sleep(7000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
