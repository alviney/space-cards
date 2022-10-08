using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    private GameObject instance;
    
    private Vector3 position;
    private Quaternion rotation;
    private Transform parent;

    private void Awake() {
        position = Vector3.zero;
        rotation = Quaternion.identity;
        parent = this.transform;
    }

    public virtual GameObject Spawn()  {
        instance = Instantiate(prefab, position, rotation, parent);
        return instance;
    }
}
