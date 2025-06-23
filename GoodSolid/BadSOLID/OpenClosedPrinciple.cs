public interface ITaskFilter
{
    List<TodoTask> Apply(List<TodoTask> tasks);
}

public class AllTasksFilter : ITaskFilter
{
    public List<TodoTask> Apply(List<TodoTask> tasks) => tasks;
}

public class CompletedTasksFilter : ITaskFilter
{
    public List<TodoTask> Apply(List<TodoTask> tasks) => tasks.Where(t => t.IsDone).ToList();
}
