using Domain.projects.TaskList.tojbect;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.Database.Configurations
{
    internal class ProjectEntityConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            throw new NotImplementedException();
            builder
                .ToTable("projects")
            .HasKey(x => x.IdProject).HasName("pk_projects");
            builder.Property(x => x.NameProject).HasColumnName("name").IsRequired().HasConversion(toDb => toDb.ProjectNameValue, fromDb => NameProject.Create(fromDb));
            
        }
    }
}
