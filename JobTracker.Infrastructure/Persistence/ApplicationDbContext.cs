using JobTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<JobApplication> JobApplications => Set<JobApplication>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("app");

        modelBuilder.Entity<JobApplication>(entity =>
        {
            entity.ToTable("JobApplications");
            entity.HasKey(x => x.Id);

            entity.Property(x => x.CompanyName)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(x => x.Position)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(x => x.AppliedAt)
                  .IsRequired();
        });
    }
}
