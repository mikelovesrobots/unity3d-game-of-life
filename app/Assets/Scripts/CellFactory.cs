using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CellFactory {
    public static CellState Create(Vector2 position, bool isAlive) {
        var instance = GameObject.Instantiate(CellPrefab, position, Quaternion.identity) as GameObject;
        instance.GetComponent<CellInitializer>().Initialize(isAlive);
        return instance.GetComponent<CellState>();
    }

    private static GameObject CellPrefab {
        get { return PrefabRepository.Instance.CellPrefab; }
    }
}
