using UnityEngine;
using System.Collections;

public class CellState : MonoBehaviour {
    private const float ANIMATION_TIME = 1f;
    public GameObject Sprite;
    public bool IsAlive;

    public void Instantiate(bool isAlive) {
        Transition(isAlive);
    }

    public void Transition(bool isAlive) {
        if (isAlive != IsAlive) {
            ScaleTo(isAlive ? Vector3.one : Vector3.zero);
        }
        IsAlive = isAlive;
    }

    private void ScaleTo(Vector3 scale) {
        var options = new Hashtable();
        options.Add("scale", scale);
        options.Add("time", ANIMATION_TIME);
        options.Add("easetype", "easeinoutquad");
        iTween.ScaleTo(Sprite, options);
    }
}
