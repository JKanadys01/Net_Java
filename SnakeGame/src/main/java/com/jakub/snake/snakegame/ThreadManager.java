package com.jakub.snake.snakegame;

public class ThreadManager {
    private Thread foodThread;

    private Game game;

    public ThreadManager(Game game) {
        this.game = game;
        foodThread = new Thread(this::moveFood);
    }

    public void start() {
        foodThread.start();
    }

    public void stop() {
        foodThread.interrupt(); // Przerywamy wątek jedzenia
    }

    private void moveFood() {
        while (true) {
            game.getFood().move();
            try {
                Thread.sleep(5000);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt(); // Przerwanie wątku w przypadku wyjątku
            }
        }
    }
}
