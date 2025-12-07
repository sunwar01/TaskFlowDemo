namespace TaskFlowDemo.Domain.Entities;

public class Board
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = default!;

    public string Name { get; set; } = default!;
    public int Order { get; set; }

    public ICollection<Column> Columns { get; set; } = new List<Column>();
}