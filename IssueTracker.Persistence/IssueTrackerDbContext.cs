using IssueTracker.Domain.Common;
using IssueTracker.Domain.Entities;
using IssueTracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Persistence
{
    public class IssueTrackerDbContext:DbContext
    {
        public IssueTrackerDbContext(DbContextOptions<IssueTrackerDbContext> options)
        : base(options) 
        { 
        } 
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<IssueSymptomRecord> IssueSymptomRecords { get; set; }
        public DbSet<AffectedPlatform> AffectedPlatforms { get; set; }
        public DbSet<RelatedIssueRecord> RelatedIssueRecords { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seed some data for testing
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76B7C5DDE}"),
                Name = "General Issue"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76C7C5DDE}"),
                Name = "Maintenance"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76D7C5DDE}"),
                Name = "Engineering"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76E7C5DDE}"),
                Name = "Accounts"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76F7C5DDE}"),
                Name = "Feedback"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC7617C5DDE}"),
                Name = "Helpdesk"

            });
            modelBuilder.Entity<Issue>().HasData(new Issue
            {
                IssueId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                AuthorId = "A0788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                OwnerId= "C0788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                IssueType = IssueType.FeatureRequest,
                Priority = Priority.High,
                Severity = Severity.Low,
                Status = Status.Done,
                Resolved = DateTime.Now,
                Summary = "The feature has been added.",
                Description = "Add shopping cart feature to the app for Mariams's biscuits.",
                CategoryId= Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76C7C5DDE}")

            });
            modelBuilder.Entity<Issue>().HasData(new Issue
            {
                IssueId = Guid.Parse("{D0788D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                AuthorId = "E0788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                OwnerId = "F0788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                IssueType = IssueType.Documentation,
                Priority = Priority.High,
                Severity = Severity.Low,
                Status = Status.InProgress,
                //Resolved = DateTime.Now,
                Summary = "Docs almost complete.",
                Description = "Add documentation for the new shopping cart feature.",
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76D7C5DDE}")

            });
            modelBuilder.Entity<Issue>().HasData(new Issue
            {
                IssueId = Guid.Parse("{A1788D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                AuthorId = "A2788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                OwnerId = "A30788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                IssueType = IssueType.Incident,
                Priority = Priority.Urgent,
                Severity = Severity.High,
                Status = Status.ToDo,
                //Resolved = DateTime.Now,
                Summary = "The EC2 instance just stopped.",
                Description = "The clients app has crashed. The issue is with the EC2 instance that keeps stopping for no clear reason.",
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76B7C5DDE}")
            });
            modelBuilder.Entity<Issue>().HasData(new Issue
            {
                IssueId = Guid.Parse("{A4788D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                AuthorId = "A5788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                OwnerId = "A6788D2F-8003-43C1-92A4-EDC76A7C5DDE",
                IssueType = IssueType.Task,
                Priority = Priority.Low,
                Severity = Severity.Low,
                Status = Status.Done,
                Resolved = DateTime.Now,
                Summary = "Call the client.",
                Description = "Add shopping cart feature to the app for Mariams's biscuits",
                CategoryId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76C7C5DDE}")
            });

            base.OnModelCreating(modelBuilder);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
