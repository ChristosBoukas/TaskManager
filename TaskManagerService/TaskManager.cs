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

}
