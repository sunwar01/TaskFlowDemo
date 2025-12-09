namespace TaskFlowDemo.Application.DTOs.ProjectDTOS;

public class CreateProjectDto
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
     
    
    // TODO: AUTH
    public Guid CreatedById { get; set; }
}