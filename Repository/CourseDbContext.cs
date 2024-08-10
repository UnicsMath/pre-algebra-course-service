using Microsoft.EntityFrameworkCore;
using Model;

namespace Service;

public class CourseDbContext : DbContext
{
    public DbSet<AuthorModel> Authors { get; init; }
    public DbSet<CourseModel> Courses { get; init; }
    public DbSet<ChapterModel> Chapters { get; init; }
    public DbSet<OperationModel> Operations { get; init; }
    
    public CourseDbContext(DbContextOptions<CourseDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChapterModel>()
            .HasMany(chapterModel => chapterModel.Operations)
            .WithMany();
    }
}