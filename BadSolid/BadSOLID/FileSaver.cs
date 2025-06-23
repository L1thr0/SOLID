public class FileSaver
{
    private const string FilePath = "tasks.txt";

    public void SaveToFile(List<TodoTask> tasks)
    {
        List<string> lines = new();
        foreach (var task in tasks)
        {
            lines.Add(task.ToString());
        }

        File.WriteAllLines(FilePath, lines);
    }
}
