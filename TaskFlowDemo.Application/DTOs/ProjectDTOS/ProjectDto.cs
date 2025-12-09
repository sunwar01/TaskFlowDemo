namespace TaskFlowDemo.Application.DTOs.ProjectDTOS;

public class ProjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsArchived { get; set; }
    public Guid CreatedById { get; set; }
}