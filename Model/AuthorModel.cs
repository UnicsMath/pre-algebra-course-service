using System.ComponentModel.DataAnnotations;

namespace Model;

public class AuthorModel
{
    [Key]
    public byte AuthorId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Degree { get; set; }
    
    public virtual ICollection<CourseModel> Courses { get; } = new List<CourseModel>();
}