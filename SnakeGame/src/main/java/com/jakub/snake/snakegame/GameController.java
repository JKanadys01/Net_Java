package com.jakub.snake.snakegame;

import javafx.animation.AnimationTimer;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.skin.TextInputControlSkin;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.layout.StackPane;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.scene.text.TextAlignment;
import javafx.stage.Stage;

import java.awt.*;

public class GameController {
    private Game game;
    private Canvas canvas;
    private ThreadManager threadManager;

    public void start(Stage stage, String size, boolean movingFood, boolean movingObsacles, int numberOfObsacles) {
        String[] dimensions = size.split("x");
        int width = Integer.parseInt(dimensions[0]);
        int height = Integer.parseInt(dimensions[1]);

        game = new Game(width, height, movingFood, movingObsacles, numberOfObsacles);
        canvas = new Canvas(width,height);
        threadManager = new ThreadManager(game);
        StackPane root = new StackPane();
        root.getChildren().add(canvas);
        Scene scene = new Scene(root, width, height);

        scene.setOnKeyPressed(this::handleKeyPress);
        stage.setTitle("Snake");
        stage.setScene(scene);
        stage.show();

        startGameLoop();
        threadManager.start();
    }

    private void startGameLoop() {
        AnimationTimer timer = new AnimationTimer() {
            long lastUpdate = 0;
            long interval = 100000000;
            @Override
            public void handle(long now) {
                if (now - lastUpdate > interval) {
                    game.update();
                    render();
                    lastUpdate = now;
                }
            }
        };
        timer.start();
    }

    private void handleKeyPress(KeyEvent event) {
        if (!game.isrunnning() && event.getCode() == KeyCode.ENTER) {
            game = new Game(game.getWidth(), game.getHeight(), game.ismovingFood(), game.ismovingObstacle(), game.getNumberOfObstacles());
            threadManager.stop();
            threadManager = new ThreadManager(game);
            threadManager.start();
        } else {
            // Aktualny kierunek węża
            TextInputControlSkin.Direction currentDirection = game.getSnake().getDirection();

            // Nowy kierunek, który chcemy ustawić
            TextInputControlSkin.Direction newDirection = null;

            // Ustalanie nowego kierunku na podstawie naciśniętego klawisza
            switch (event.getCode()) {
                case UP:
                    newDirection = TextInputControlSkin.Direction.UP;
                    break;
                case DOWN:
                    newDirection = TextInputControlSkin.Direction.DOWN;
                    break;
                case LEFT:
                    newDirection = TextInputControlSkin.Direction.LEFT;
                    break;
                case RIGHT:
                    newDirection = TextInputControlSkin.Direction.RIGHT;
                    break;
            }

            // Sprawdzenie czy nowy kierunek nie jest przeciwny do obecnego
            if (newDirection != null && !isOppositeDirection(currentDirection, newDirection)) {
                game.getSnake().changeDirection(newDirection);

            }
        }
    }

    // Metoda sprawdzająca czy nowy kierunek jest przeciwny do obecnego
    private boolean isOppositeDirection(TextInputControlSkin.Direction currentDirection, TextInputControlSkin.Direction newDirection) {
        return (currentDirection == TextInputControlSkin.Direction.UP && newDirection == TextInputControlSkin.Direction.DOWN) ||
                (currentDirection == TextInputControlSkin.Direction.DOWN && newDirection == TextInputControlSkin.Direction.UP) ||
                (currentDirection == TextInputControlSkin.Direction.LEFT && newDirection == TextInputControlSkin.Direction.RIGHT) ||
                (currentDirection == TextInputControlSkin.Direction.RIGHT && newDirection == TextInputControlSkin.Direction.LEFT);
    }

    private void render() {
        GraphicsContext gc = canvas.getGraphicsContext2D();
        gc.clearRect(0, 0, canvas.getWidth(), canvas.getHeight());


        // Rysowanie węża
        for (Point point : game.getSnake().getBody()) {
            gc.setFill(Color.GREEN);
            gc.fillRect(point.getX() * 20, point.getY() * 20, 20, 20);
        }

        // Rysowanie jedzenia
        Point foodPos = game.getFood().getPosition();
        gc.setFill(Color.RED);
        gc.fillOval(foodPos.getX() * 20, foodPos.getY() * 20, 20, 20);

        // Rysowanie przeszkod
        for (Obstacle obstacle : game.getObstacles()) {
            gc.setFill(Color.BLACK);
            Point pos = obstacle.getLocation();
            gc.fillRect(pos.getX() * 20, pos.getY() * 20, 20, 20);
        }

        //Rysowanie score
        gc.setFill(Color.BLACK);
        gc.fillText("Score: " + game.getScore(), canvas.getWidth() - 70, 20);

        if (!game.isrunnning()) {
            gc.setFill(Color.RED);
            gc.setFont(new Font("Arial", 30));
            gc.setTextAlign(TextAlignment.CENTER);
            gc.fillText("GAME OVER", canvas.getWidth() / 2, canvas.getHeight() / 2);
            gc.setFill(Color.BLACK);
            gc.setFont(new Font("Arial", 12));
            gc.fillText("Press ENTER to restart", canvas.getWidth() / 2, canvas.getHeight() / 2 + 30);
        }
    }

}
