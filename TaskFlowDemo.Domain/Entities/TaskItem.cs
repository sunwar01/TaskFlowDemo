using TaskFlowDemo.Domain.Enums;

namespace TaskFlowDemo.Domain.Entities;

public class TaskItem
{
    public Guid Id { get; set; }

    public Guid ColumnId { get; set; }
    public Column Column { get; set; } = default!;

    public string Title { get; set; } = default!;
    public string? Description { get; set; }

    public Guid? AssigneeId { get; set; }
    public User? Assignee { get; set; }

    public Guid CreatedById { get; set; }
    public User CreatedBy { get; set; } = default!;

    public Priority Priority { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime CreatedAt { get; set; }

    public int Order { get; set; }

    public ICollection<TaskComment> Comments { get; set; } = new List<TaskComment>();
    public ICollection<TaskLabel> TaskLabels { get; set; } = new List<TaskLabel>();
}