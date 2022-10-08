using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public PersonModel model;

    public int level;

    public Stat health;
    public Stat strength;
    public Stat speed;

    public void Initialise(PersonModel person) {
        this.model = person;

        this.level = person.level;
        this.health = new Stat(person.health);
        this.strength = new Stat(person.strength);
        this.speed = new Stat(person.speed);
    }
}
