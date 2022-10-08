using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonInitialiser : Initialiser
{
    public SO_PersonCollection personCollection;

    public List<PersonModel> persons;

    protected override void LoadDependencies() {
        if (Store.data.persons.Count == 0) {
            Store.data.persons.Add(personCollection.NewPerson());
        }
    
        persons = Store.data.persons;
    }

    public override void Initialise() {
        base.Initialise();
    }
}

