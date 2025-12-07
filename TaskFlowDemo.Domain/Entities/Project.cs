namespace TaskFlowDemo.Domain.Entities;

public class Project
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsArchived { get; set; }

    public Guid CreatedById { get; set; }
    public User CreatedBy { get; set; } = default!;

    public ICollection<ProjectMember> Members { get; set; } = new List<ProjectMember>();
    public ICollection<Board> Boards { get; set; } = new List<Board>();
    public ICollection<Label> Labels { get; set; } = new List<Label>();
}