public class TaskSaver
{
    private FileSaver _fileSaver = new();

    public void Save(List<TodoTask> tasks)
    {
        _fileSaver.SaveToFile(tasks);
    }
}
