module com.jakub.snake.snakegame {
    requires javafx.controls;
    requires javafx.fxml;

    requires com.almasb.fxgl.all;
    requires java.desktop;

    opens com.jakub.snake.snakegame to javafx.fxml;
    exports com.jakub.snake.snakegame;
}