using Microsoft.EntityFrameworkCore;
using Model;

namespace Service;

public class CourseDbContext : DbContext
{
    public DbSet<AuthorModel> Authors { get; set; }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<ChapterModel> Chapters { get; set; }
    public DbSet<OperatorModel> Operators { get; set; }
    
    public CourseDbContext(DbContextOptions<CourseDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChapterModel>()
            .HasMany(chapterModel => chapterModel.Operators)
            .WithMany();
    }
}