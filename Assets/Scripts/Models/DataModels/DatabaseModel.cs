using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseModel : DataModel
{
    /// <summary>Unique ID<summary/>
    public string id;

    public DatabaseModel(string id) {
        this.id = id;
    }
}
