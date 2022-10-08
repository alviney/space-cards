using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public Spawner spawner;

    private void Awake() {
        if (instance == null) instance = this;    
        else Destroy(this.gameObject);
    }

    public virtual void Initialise() {}
}
