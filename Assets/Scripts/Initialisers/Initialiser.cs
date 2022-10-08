using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Initialiser : MonoBehaviour
{
    public GameObject prefab;

    private GameObject instance;

    public virtual void Initialise() {
        LoadDependencies();
    }

    protected abstract void LoadDependencies();

    public void Spawn() {
        instance = Instantiate(prefab);
    }
}
