using System.Collections.Generic;

public class TaskModel : DatabaseModel
{
    public TickRate tickRate = TickRate.Second;
    public int limit = 1;
    public float percentageComplete;

    protected List<string> personIds = new List<string>();

    public TaskModel(string id) : base(id)
    {

    }
}
