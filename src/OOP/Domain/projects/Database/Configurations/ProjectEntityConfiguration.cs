using Domain.projects.pobject;
using Domain.projects.TaskList.tojbect;
using Domain.projects.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.projects.Database.Configurations
{
    sealed class ProjectEntityConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("projects");

            builder.HasKey(x => x.IdProject).HasName("pk_projects");

            builder
                .Property(x => x.IdProject)
                .HasColumnName("id")
                .HasConversion(toDb => toDb.Id, fromDb => IdProject.Create(fromDb));

            builder
                .Property(x => x.NameProject)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(NameProject.MAX_VALUE_PROJECTNAME)
                .HasConversion(toDb => toDb.ProjectNameValue, fromDb => NameProject.Create(fromDb));

            builder.HasIndex(x => x.NameProject).IsUnique();

            builder
                .Property(x => x.FinishDataProject)
                .HasColumnName("FinishDataProject")
                .IsRequired(false)
                .HasConversion(toDb => ConvertFinishDataProjectToDateTime(toDb), fromDb => ConvertFinishDataProjectFromDateTime(fromDb));

                 builder
                .Property(x => x.StartDataProject)
                .HasColumnName("StartDataProject")
                .IsRequired()
                .HasConversion(toDb => toDb.StartDateProject, fromDb => StartDataProject.Create(fromDb));

            builder
                .HasMany(x => x.Tasks)
                .WithOne(x => x.Project)
                .HasForeignKey(x => x.IdProject)
                .HasConstraintName("fk_project")
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            
        }
        private static DateTime? ConvertFinishDataProjectToDateTime (FinishDataProject? value)
        {
            if (value == null) return null;
            else return value.FinishDateProject.Date;
        }
        private static FinishDataProject? ConvertFinishDataProjectFromDateTime (DateTime? value)
        {
            if (value == null) return null;
            else return FinishDataProject.Create(value.Value);
        }
        
    }

    sealed class ProjectTaskEntityConfiguration : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.ToTable("project_tasks");

            builder
                .HasKey(x => x.TaskId)
                .HasName("pk_project_tasks");

            builder
                .Property(x => x.TaskId)
                .HasColumnName("id")
                .HasConversion(toDb => toDb.Id, fromDb => TaskId.Create(fromDb));

            builder
                .Property(x => x.LvlImortance)
                .HasColumnName("LvlImortance")
                .IsRequired()
                .HasConversion(toDb => toDb.LvlImortanc, fromDb => LvlImortance.Create(fromDb));

            builder
                .Property(x => x.Progres)
                .HasColumnName("Progres")
                .IsRequired()
                .HasConversion(toDb => toDb.progres, fromDb => Progres.Create(fromDb));

            builder
                .Property(x => x.StartDataTask)
                .HasColumnName("StartDataTask")
                .HasConversion(toDb => toDb.StartDateTask, fromDb => StartDataTask.Create(fromDb));
        }
    }
}
