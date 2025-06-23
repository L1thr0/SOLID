public class TaskManager
{
    private List<string> tasks = new();

    public void Add(string task) => tasks.Add(task);
    public List<string> GetAll() => tasks;
}

public class FileStorage
{
    public void Save(List<string> tasks) => File.WriteAllLines("tasks.txt", tasks);
}

public class ConsolePrinter
{
    public void Print(List<string> tasks) => tasks.ForEach(Console.WriteLine);
}
