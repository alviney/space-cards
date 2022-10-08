using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat 
{
    [SerializeField]
    private int baseValue;
    private List<int> modifiers = new List<int>();

    public Stat(int baseValue = 0) {
        this.baseValue = baseValue;
    }

    public int value {
        get {
            int finalValue = baseValue;
            modifiers.ForEach(x => finalValue += x);
            return finalValue;
        }
    }

    public void AddModifier (int modifier) {
        if (modifier != 0)
            modifiers.Add(modifier);
    }

    public void RemoveModifier(int modifier) {
        if (modifier != 0) {
            modifiers.Remove(modifier);
        }
    }
}
