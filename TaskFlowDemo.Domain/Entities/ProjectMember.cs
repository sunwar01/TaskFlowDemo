using TaskFlowDemo.Domain.Enums;

namespace TaskFlowDemo.Domain.Entities;

public class ProjectMember
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = default!;

    public Guid UserId { get; set; }
    public User User { get; set; } = default!;

    public ProjectRole Role { get; set; }
    public DateTime JoinedAt { get; set; }
}