using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CellFactory {
    public static GameObject Create(Vector2 position) {
        return GameObject.Instantiate(CellPrefab, position, Quaternion.identity) as GameObject;
    }

    private static GameObject CellPrefab {
        get { return PrefabRepository.Instance.CellPrefab; }
    }
}
