package com.jakub.snake.snakegame;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

public class GameLogger {
    private static final String LOG_FILE = "GameLog.log";

    public static void log(String message) {
        try(PrintWriter out = new PrintWriter(new FileWriter(LOG_FILE,true))) {
            out.println(message);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
