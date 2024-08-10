using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class CourseModel
{
    [Key]
    public byte CourseId { get; init; }
    
    [Required]
    [MaxLength(128, ErrorMessage="CourseName must be 128 characters or less"),MinLength(5)]
    public string Name { get; init; }
    
    [Required]
    public string Description { get; init; }
    
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime Created { get; init; }
    
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Updated { get; init; }
    
    [ForeignKey("AuthorModel")]
    public byte AuthorId { get; init; }
    public virtual AuthorModel Author { get; init; }
    
    public virtual ICollection<ChapterModel> Chapters { get; init; } = new List<ChapterModel>();
}