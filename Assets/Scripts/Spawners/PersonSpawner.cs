using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : Spawner
{
        public Person SpawnPerson(PersonModel model) {
        GameObject instance = this.Spawn();
        Person person = instance.GetComponent<Person>();
        person.Initialise(model);
        return person;
    }
}
