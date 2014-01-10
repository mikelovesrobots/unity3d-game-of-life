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
                Matrix[x, y].SetActive(true);
            }
        }
    }

    public bool HasCell(int x, int y) {
        return Matrix[x, y] != null;
    }
}
