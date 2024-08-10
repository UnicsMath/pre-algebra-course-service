using System.ComponentModel.DataAnnotations;

namespace Model;

public class AuthorModel
{
    [Key]
    public byte AuthorId { get; init; }
    public string Name { get; init; }
    public string Title { get; init; }
    public string Degree { get; init; }
    
    public virtual ICollection<CourseModel> Courses { get; } = new List<CourseModel>();
}