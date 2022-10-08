using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public Initialiser[] initialisers;
    public Manager[] managers;

    private void Awake() {
        Store.Load();
        RunInitialisers();

        InvokeRepeating("RunSecondTick", 0, 1);
    }

    private void RunSecondTick() {
        Clock.RunSecondTick();
    }

    private void RunInitialisers() {
        foreach (Initialiser initialiser in initialisers) initialiser.Initialise();
    }

    private void InitialiseManagers() {
        foreach (Manager manager in managers) manager.Initialise();
    }
}
