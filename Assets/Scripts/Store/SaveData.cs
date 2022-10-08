using System.Collections.Generic;

[System.Serializable]
public class SaveData
{
    public List<ShipModel> ships = new List<ShipModel>();
    public List<PersonModel> persons = new List<PersonModel>();
    public List<CrewModel> crews = new List<CrewModel>();
    public List<TaskModel> tasks = new List<TaskModel>();
}
