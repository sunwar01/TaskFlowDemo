namespace TaskFlowDemo.Domain.Entities;

public class TaskComment
{
    public Guid Id { get; set; }

    public Guid TaskId { get; set; }
    public TaskItem Task { get; set; } = default!;

    public Guid AuthorId { get; set; }
    public User Author { get; set; } = default!;

    public string Message { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
}