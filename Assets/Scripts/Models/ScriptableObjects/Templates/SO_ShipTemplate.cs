using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Templates/Ship", order = 1)]
public class SO_ShipTemplate : ScriptableObject, I_Ship
{
    public float _fuel;
    public float fuel { get => _fuel; set { _fuel = value; } }
}
