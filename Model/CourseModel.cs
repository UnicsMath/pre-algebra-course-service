using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class CourseModel
{
    public long CourseId { get; set; }
    
    [Required]
    [MaxLength(128, ErrorMessage="CourseName must be 128 characters or less"),MinLength(5)]
    public string Name { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime Created { get; set; }
    
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Updated { get; set; }
    
    [ForeignKey("AuthorModel")]
    public long AuthorId { get; set; }
    public virtual AuthorModel Author { get; set; }
    
    public virtual ICollection<ChapterModel> Chapters { get; init; } = new List<ChapterModel>();
}