using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public ShipModel model;

    public void Initialise(ShipModel ship) {
        this.model = ship;
    }

    public void AddPersonToCrew(Person person) {
        Store.AddPersonToShip(this.model.id, person.model.id);
    }
}
