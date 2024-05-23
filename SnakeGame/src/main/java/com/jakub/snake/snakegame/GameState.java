package com.jakub.snake.snakegame;

import java.awt.*;
import java.io.FileWriter;
import java.io.PrintWriter;

public class GameState {
    private static final String SAVE_FILE = "GameState.txt";

    public static void save(Game game) {
        try(PrintWriter out = new PrintWriter(new FileWriter(SAVE_FILE))) {
            out.println("SNAKE");
            for (Point point : game.getSnake().getBody()) {
                out.println(point.getX() + "," + point.getY());
            }

            Point foodPos = game.getFood().getPosition();
            out.println("FOOD");
            out.println(foodPos.getX() + "," + foodPos.getY());

            out.println("SCORE");
            out.println(game.getScore());

            GameLogger.log("Game state saved");
        } catch (Exception e) {
            e.printStackTrace();
        }

    }
}
