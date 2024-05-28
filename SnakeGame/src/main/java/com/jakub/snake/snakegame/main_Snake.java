package com.jakub.snake.snakegame;

import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.ComboBox;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class main_Snake extends Application {
    @Override
    public void start(Stage primaryStage) {
        GameController gameController = new GameController();

        // Menu początkowe
        VBox menu = new VBox();
        menu.setAlignment(Pos.CENTER);

        // ComboBox do wyboru rozmiaru planszy
        ComboBox<String> sizeComboBox = new ComboBox<>();
        sizeComboBox.getItems().addAll("400x400", "600x600", "800x800");
        sizeComboBox.setValue("400x400");

        //ChecBox do wyboru ilosci przeszkod

        // CheckBox do wyboru ruchomego jedzenia i przeszkód
        CheckBox movingFoodCheckBox = new CheckBox("Moving Food");
        CheckBox movingObstaclesCheckBox = new CheckBox("Moving Obstacles");

        // Przycisk Start
        Button startButton = new Button("Start Game");
        startButton.setOnAction(e -> {
            String size = sizeComboBox.getValue();
            boolean movingFood = movingFoodCheckBox.isSelected();
            boolean movingObstacles = movingObstaclesCheckBox.isSelected();
            int numberOfObstacles = 0;
            if (size.equals("400x400")) {
                numberOfObstacles = 5;
            }else if (size.equals("600x600")) {
                numberOfObstacles = 10;
            }else if (size.equals("800x800")) {
                numberOfObstacles = 30;
            }
            gameController.start(primaryStage, size, movingFood, movingObstacles, numberOfObstacles);
        });

        menu.getChildren().addAll(sizeComboBox, movingFoodCheckBox, movingObstaclesCheckBox, startButton);

        Scene menuScene = new Scene(menu, 400, 400);
        primaryStage.setScene(menuScene);
        primaryStage.setTitle("Snake Game Menu");
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
