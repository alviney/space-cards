using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonsManager : Manager
{
    public List<Person> persons = new List<Person>();

    public void Initialise(PersonInitialiser initialiser) {
        foreach (PersonModel model in initialiser.persons)
        {
            persons.Add(((PersonSpawner)spawner).SpawnPerson(model));
        }
    }
}
