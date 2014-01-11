using UnityEngine;
using System.Collections;

public class OnMouseOverEnableCell : MonoBehaviour {
    public CellState CellState;

    public void OnMouseOver() {
        CellState.InstantTransition(true);
    }
}
