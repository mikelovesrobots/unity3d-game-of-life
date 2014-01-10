using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardTicker : MonoBehaviour {
    private Board board;

    public void Initialize(Board board) {
        this.board = board;
    }

    public void Tick() {
        Debug.Log("tick");
    }
}
