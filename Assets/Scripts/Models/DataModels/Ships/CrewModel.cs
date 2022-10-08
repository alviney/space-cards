using System.Collections.Generic;

public class CrewModel : DatabaseModel
{
    public string shipId;
    public List<string> personIds = new List<string>();

    public CrewModel(string id, string shipId) : base(id)
    {
        this.shipId = shipId;
    }
}
