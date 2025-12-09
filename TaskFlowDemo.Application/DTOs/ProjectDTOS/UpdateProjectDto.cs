namespace TaskFlowDemo.Application.DTOs.ProjectDTOS;

public class UpdateProjectDto
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public bool IsArchived { get; set; }
}