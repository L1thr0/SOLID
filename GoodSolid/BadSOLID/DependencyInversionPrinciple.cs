public interface ITaskSaver
{
    void Save(List<TodoTask> tasks);
}

public class FileSaver : ITaskSaver
{
    public void Save(List<TodoTask> tasks)
    {
        // save logic
    }
}

public class TaskSaver
{
    private readonly ITaskSaver _saver;
    public TaskSaver(ITaskSaver saver) => _saver = saver;

    public void Save(List<TodoTask> tasks) => _saver.Save(tasks);
}
