namespace TaskFlowDemo.Domain.Entities;

public class Label
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = default!;

    public string Name { get; set; } = default!;
    public string Color { get; set; } = "#FFFFFF";

    public ICollection<TaskLabel> TaskLabels { get; set; } = new List<TaskLabel>();
}