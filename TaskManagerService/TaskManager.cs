namespace TaskManagerService;

public class TaskManager
{
    private int NextId = 1;
    public List<Task> Tasks { get; set; } = [];

    public bool AddTask(string Name, string Description)
    {
        Task task = new Task();
        task.Name = Name;
        task.Description = Description;
        task.Id = NextId;
        NextId++;
        task.IsCompleted = false;

        Tasks.Add(task);

        return true;
    }

    public void CompleteTaskById(int Id)
    {
        //try
        //{
        //    foreach (Task task in Tasks)
        //    {
        //        if (task.Id == Id)
        //        {
        //            task.IsCompleted = true;
        //        }
        //    }
        //}
        //catch (Exception e)
        //{

        //}

        var task = Tasks.FirstOrDefault(task => task.Id == Id);

        if (task is not null)
        {
            task.IsCompleted = true;
        }
        else
        { 
            throw new ArgumentException("Given task" + Id + "not found.");
        }

    }

    public List<Task> GetAllTasks()
    {
        return null;


    }

}


