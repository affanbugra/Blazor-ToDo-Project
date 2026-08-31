public class KanbanTask
{
    public string? Title { get; set; }
    public Progress Status { get; set; } = Progress.NotStarted;
    public Priority Level { get; set; } = Priority.Normal;

    public DateOnly? DueDate { get; set; }
}

public enum Progress
{
    NotStarted,
    InProgress,
    Completed
}


public enum Priority
{
    Low,
    Normal,
    High
}

