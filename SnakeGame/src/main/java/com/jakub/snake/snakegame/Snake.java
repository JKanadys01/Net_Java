package com.jakub.snake.snakegame;

import javafx.scene.control.skin.TextInputControlSkin;

import java.awt.*;
import java.util.LinkedList;

public class Snake {
    private LinkedList<Point> body;
    private TextInputControlSkin.Direction direction;

    public Snake() {
        body = new LinkedList<>();
        direction = TextInputControlSkin.Direction.RIGHT;
        body.add(new Point(10, 10));  // Głowa węża
    }

    public void move() {
        Point newHead = getNextPosition();
        // Zapewnienie by snake nie wyszedl poza plansze
        if (newHead.getX() >= 20) {
            newHead.setLocation(0, newHead.getY());
        } else if (newHead.getX() < 0) {
            newHead.setLocation(19, newHead.getY());
        }
        if (newHead.getY() >= 20) {
            newHead.setLocation(newHead.getX(), 0);
        } else if (newHead.getY() < 0) {
            newHead.setLocation(newHead.getX(), 19);
        }
        body.addFirst(newHead);
        body.removeLast();
    }

    public void grow() {
        Point tail = body.getLast();
        body.add(new Point((int)tail.getX(), (int)tail.getY()));
    }

    public boolean collidesWithItself() {
        Point head = body.getFirst();
        for (int i = 1; i < body.size(); i++) {
            if (head.equals(body.get(i))) {
                return true;
            }
        }
        return false;
    }

    private Point getNextPosition() {
        Point head = body.getFirst();
        switch (direction) {
            case UP: return new Point((int) head.getX(), (int) (head.getY() - 1));
            case DOWN: return new Point((int) head.getX(), (int) (head.getY() + 1));
            case LEFT: return new Point((int) (head.getX() - 1), (int) head.getY());
            case RIGHT: return new Point((int) (head.getX() + 1), (int) head.getY());
            default: return head;
        }
    }

    public void changeDirection(TextInputControlSkin.Direction newDirection) {
        direction = newDirection;
    }

    // Metoda sprawdzająca, czy punkt znajduje się na ciele węża
    public boolean contains(Point point) {
        for (Point bodyPart : body) {
            if (bodyPart.equals(point)) {
                return true;
            }
        }
        return false;
    }

    public Point getHead() {
        return body.getFirst();
    }

    public LinkedList<Point> getBody() {
        return body;
    }
    public TextInputControlSkin.Direction getDirection() {
        return direction;
    }
}
