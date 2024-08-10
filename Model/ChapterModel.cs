using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class ChapterModel
{
    [Key]
    public ushort ChapterId { get; init; }
    
    [Required]
    public ushort ChapterNumber { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    [Required]
    public string Content { get; set; }
    
    [Required]
    public ushort MinimumLength { get; set; }
    
    [Required]
    public ushort MaximumLength { get; set; }
    
    [Required]
    public ushort MinimumConstantValue { get; set; }
    
    [Required]
    public ushort MaximumConstantValue { get; set; }
    
    [ForeignKey("CourseModel")]
    public byte CourseId { get; init; }
    public virtual CourseModel Course { get; init; }

    // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many#unidirectional-many-to-many
    // note: this is a unidirectional many-to-many relationship
    [Required] 
    public IEnumerable<OperationModel> Operations { get; init; } = new List<OperationModel>();
}