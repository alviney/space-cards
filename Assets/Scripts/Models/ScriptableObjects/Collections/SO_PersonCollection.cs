using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Collections/Person", order = 1)]
public class SO_PersonCollection : ScriptableObject
{
    public SO_PersonItem[] items;

    public PersonModel NewPerson() {
        SO_PersonItem template = items[0];
        PersonModel model = new PersonModel(template.name);
        return model;
    }
}
