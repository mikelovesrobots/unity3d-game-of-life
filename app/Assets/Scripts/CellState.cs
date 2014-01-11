using UnityEngine;
using System.Collections;

public class CellState : MonoBehaviour {
    private const float DEFAULT_ANIMATION_TIME = 1f;
    public GameObject Sprite;
    public bool IsAlive;

    public void Instantiate(bool isAlive) {
        InstantTransition(isAlive);
    }

    public void InstantTransition(bool isAlive) {
        iTween.Stop(Sprite);
        Sprite.transform.localScale = DestinationScale(isAlive);
        IsAlive = isAlive;
    }
    
    public void Transition(bool isAlive) {
        if (isAlive != IsAlive) {
            ScaleTo(DestinationScale(isAlive));
        }
        IsAlive = isAlive;
    }

    private void ScaleTo(Vector3 scale) {
        var options = new Hashtable();
        options.Add("scale", scale);
        options.Add("time", DEFAULT_ANIMATION_TIME);
        options.Add("easetype", "easeinoutquad");
        iTween.ScaleTo(Sprite, options);
    }

    private Vector3 DestinationScale(bool isAlive) {
        return isAlive ? Vector3.one : Vector3.zero;
    }
}
