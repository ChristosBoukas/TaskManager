using Microsoft.VisualBasic;
using TaskManagerService;

namespace taskmanagerservice.tests;

[TestClass]
public class UnitTest1
{
    //[TestMethod]
    //public void AddTask1()
    //{
    //    // Arrange
    //    TaskManager taskManager = new TaskManager();

    //    // Act
    //    var result = taskManager.AddTask("task.Name", "task.Description");


    //    // Assert
    //    Assert.IsTrue(result);
    //    Assert.IsNotNull(taskManager.Tasks[0].Id);
    //    Assert.IsFalse(taskManager.Tasks[0].IsCompleted);
    //}

    [TestMethod]
    public void CompletTaskById_ShouldSetIsCompletedToTrueOnCorrectTask()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.AddTask("NewTask", "The New Task");
        var id = taskManager.Tasks[0].Id;

        taskManager.CompleteTaskById(id);

        Assert.IsTrue(taskManager.Tasks[0].IsCompleted);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Task with given id should not have existed")]
    public void CompletTaskById_ShouldThrowExceptionIfNoTaskWithGivenIdExists()
    {
        TaskManager taskManager = new TaskManager();

        taskManager.CompleteTaskById(90);
    }

    [TestMethod]
    public void GetAllTasks_ShouldReturnListOfAllTasks()
    {
        TaskManager taskManager = new TaskManager();
        string name1 = "Name1";
        string name2 = "name2";
        string description1 = "Task desc1";
        string description2 = "Task desc2";

        taskManager.AddTask(name1, description1);
        taskManager.AddTask(name2, description2);

        List<Task> tasks = taskManager.GetAllTasks();

        Assert.AreEqual(2, tasks.Count);
        Assert.AreEqual(description1, tasks.FirstOrDefault(task => task.Name.Equals(name1)).Description);
        Assert.AreEqual(description2, tasks.FirstOrDefault(task => task.Name.Equals(name2)).Description);
    }

    [TestMethod]
    public void GetAllTasks_ShouldReturnEmptyListIfNoTasksExist()
    {
        TaskManager taskManager = new TaskManager();


        List<Task> tasks = taskManager.GetAllTasks();

        Assert.IsNotNull(tasks);
        Assert.AreEqual(0, tasks.Count);

    }
}