using System.Collections.Generic;

public class Task
{
    protected List<Person> persons = new List<Person>();
    protected TaskModel model;

    public Task(TaskModel model)
    {
        this.model = model;
    }

    public virtual void NextTick()
    {

    }

    public bool AddPerson(Person person)
    {

        if (persons.Count < model.limit)
        {
            persons.Add(person);
            return true;
        }

        return false;
    }

    public void RemovePerson(Person person)
    {
        persons.Remove(person);
    }

    public TickRate tickRate
    {
        get => model.tickRate;
    }
}
