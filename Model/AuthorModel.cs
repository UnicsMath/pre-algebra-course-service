namespace Model;

public class AuthorModel
{
    public long AuthorId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Degree { get; set; }
    
    public virtual ICollection<CourseModel> Courses { get; } = new List<CourseModel>();
}