using TaskManagerService;

namespace taskmanagerservice.tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void AddTask()
    {
        // Arrange
        TaskManager taskManager = new TaskManager();
        //Task task = new Task();
        //task.Id = 1;
        //task.Name = "Test";
        //task.Description = "Test";
        //task.IsCompleted = false;

        // Act
        var result = taskManager.AddTask("task.Name", "task.Description");


        // Assert
        Assert.IsTrue(result);
        Assert.IsNotNull(taskManager.Tasks[0].Id);
        Assert.IsFalse(taskManager.Tasks[0].IsCompleted);
    }
}