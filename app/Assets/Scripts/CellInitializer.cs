using UnityEngine;
using System.Collections;

public class CellInitializer : MonoBehaviour {
    public Animator Animator;
    public CellState CellState;

    public void Initialize(bool isAlive) {
        CellState.Instantiate(isAlive);
        StartCoroutine(WaitThenAnimate());
    }
    
    private IEnumerator WaitThenAnimate() {
        yield return new WaitForSeconds(RandomWait);
        Animator.enabled = true;
    }

    private float RandomWait {
        get { return Random.Range(0, 0.5f); }
    }
}
