using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskFlowDemo.Domain.Entities;

namespace TaskFlowDemo.Infrastructure.Configurations;

public class ProjectMemberConfiguration : IEntityTypeConfiguration<ProjectMember>
{
    public void Configure(EntityTypeBuilder<ProjectMember> builder)
    {
        builder.ToTable("ProjectMembers");

        builder.HasKey(pm => pm.Id);

        builder.Property(pm => pm.JoinedAt)
            .HasDefaultValueSql("GETUTCDATE()");
        
        builder.HasIndex(pm => new { pm.ProjectId, pm.UserId })
            .IsUnique();
    }
}