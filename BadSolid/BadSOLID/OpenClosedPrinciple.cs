List<TodoTask> FilterTasks(List<TodoTask> tasks, string filter)
{
    if (filter == "all") return tasks;
    if (filter == "completed") return tasks.Where(t => t.IsDone).ToList();
    if (filter == "active") return tasks.Where(t => !t.IsDone).ToList();
    return tasks;
}
