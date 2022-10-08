using System.Collections.Generic;

public class TaskManager : Manager
{
    public List<Task> tasks = new List<Task>();

    public void Initialise(TaskInitialiser taskInitialiser)
    {
        foreach (TaskModel model in taskInitialiser.tasks)
        {
            Task task = new Task(model);
            tasks.Add(task);
        }
    }

    private void OnEnable()
    {
        Clock.onSecondTick += OnSecondTick;
    }

    private void OnDisabled()
    {
        Clock.onSecondTick -= OnSecondTick;
    }

    private void OnSecondTick()
    {
        foreach (Task task in tasks)
        {
            if (task.tickRate == TickRate.Second)
            {
                task.NextTick();
            }
        }
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void RemoveTask(Task task)
    {
        tasks.Remove(task);
    }
}
