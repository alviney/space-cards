using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : Spawner
{
    public Ship SpawnShip(ShipModel model) {
        GameObject instance = this.Spawn();
        Ship ship = instance.GetComponent<Ship>();
        ship.Initialise(model);
        return ship;
    }
}
