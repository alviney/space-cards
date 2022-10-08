using System.Collections.Generic;

public class TaskInitialiser : Initialiser
{
    public List<TaskModel> tasks;

    protected override void LoadDependencies()
    {
        tasks = Store.data.tasks;
    }

    public override void Initialise()
    {
        base.Initialise();
    }
}
