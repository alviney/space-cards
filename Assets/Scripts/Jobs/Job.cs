using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Job
{
    public Task activeTask;
    
    public abstract Task GetTask();
}
