public class TodoService
{
    private List<string> tasks = new();

    public void Add(string task) => tasks.Add(task);

    public void SaveToFile() => File.WriteAllLines("tasks.txt", tasks);

    public void PrintTasks() => tasks.ForEach(Console.WriteLine);
}
