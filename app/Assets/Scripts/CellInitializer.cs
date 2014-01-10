using UnityEngine;
using System.Collections;

public class CellInitializer : MonoBehaviour {
    public Animator Animator;
    void Start () {
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
