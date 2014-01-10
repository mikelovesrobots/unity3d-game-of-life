using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Board {
    public const int SIZE = 25;
    public GameObject[,] Matrix;

    public Board() {
        Matrix = new GameObject[SIZE, SIZE];

        for (int x = 0; x < SIZE; x++) {
            for (int y = 0; y < SIZE; y++) {
                var cell = CellFactory.Create(new Vector3(x - (SIZE / 2), y - (SIZE / 2), 0));
                Matrix[x, y] = cell;
                Matrix[x, y].SetActive(Random.Range(1, 3) == 1);
            }
        }
    }

    public GameObject Cell(int x, int y) {
        return Matrix[x, y];
    }

    public bool IsLiveCell(int x, int y) {
        return Matrix[x, y].activeSelf;
    }

    public int LiveNeighborCount(int x, int y) {
        var count = 0;
        for (int i = -1; i <= 1; i++) {
            for (int j = -1; j <= 1; j++) {
                if (!(i == 0 && j == 0)) {
                    var newX = x + i;
                    var newY = y + j;
                    if (IsOnBoard(newX, newY) && IsLiveCell(newX, newY)) {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    private bool IsOnBoard(int x, int y) {
        return x >= 0 && y >= 0 && x < SIZE && y < SIZE;
    }
}
