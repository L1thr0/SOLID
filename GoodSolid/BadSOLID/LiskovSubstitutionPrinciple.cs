public class ReadOnlyTask
{
    private readonly TodoTask _task;

    public ReadOnlyTask(TodoTask task)
    {
        _task = task;
    }

    public string Description => _task.Description;
    public bool IsDone => _task.IsDone;

}
