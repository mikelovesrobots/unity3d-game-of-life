using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardTicker : MonoBehaviour {
    private Board board;

    public void Initialize(Board board) {
        this.board = board;
    }

    public void Tick() {
        SyncBoard(NextGeneration());
    }

    private bool[,] NextGeneration() {
        var nextGeneration = new bool[Board.SIZE, Board.SIZE];

        for (int x = 0; x < Board.SIZE; x++) {
            for (int y = 0; y < Board.SIZE; y++) {
                /* Any live cell with fewer than two live neighbours dies, as if caused by under-population. */
                /* Any live cell with two or three live neighbours lives on to the next generation. */
                /* Any live cell with more than three live neighbours dies, as if by overcrowding. */
                /* Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction. */
                var neighborCount = board.LiveNeighborCount(x, y);
                if (board.IsLiveCell(x, y)) {
                    nextGeneration[x, y] = (neighborCount == 2 || neighborCount == 3);
                } else if (neighborCount == 3) {
                    nextGeneration[x, y] = true;
                }
            }
        }

        return nextGeneration;
    }

    private void SyncBoard(bool[,] nextGeneration) {
        for (int x = 0; x < Board.SIZE; x++) {
            for (int y = 0; y < Board.SIZE; y++) {
                board.Cell(x, y).Transition(nextGeneration[x, y]);
            }
        }
    }
}
