public class TodoTask
{
    public bool IsDone { get; private set; }

    public virtual void MarkDone()
    {
        IsDone = true;
    }
}
