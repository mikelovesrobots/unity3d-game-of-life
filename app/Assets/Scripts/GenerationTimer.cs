using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerationTimer : MonoBehaviour {
    private const float DELAY_BETWEEN_TICKS = 0.5f;
    private BoardTicker boardTicker;

    public void Initialize(BoardTicker boardTicker) {
        this.boardTicker = boardTicker;
        StartCoroutine(WaitThenTick());
    }

    public IEnumerator WaitThenTick() {
        yield return new WaitForSeconds(DELAY_BETWEEN_TICKS);
        boardTicker.Tick();
        StartCoroutine(WaitThenTick());
    }
}
