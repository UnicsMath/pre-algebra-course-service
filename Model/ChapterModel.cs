using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class ChapterModel
{
    public ushort ChapterId { get; set; }
    
    [Required]
    public ushort ChapterNumber { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public ExpressionConfiguration ExpressionConfiguration { get; set; }
    
    [ForeignKey("CourseModel")]
    public long CourseId { get; set; }
    public virtual CourseModel Course { get; set; }

    // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many#unidirectional-many-to-many
    // note: this is a unidirectional many-to-many relationship
    /// <summary>
    ///     The list of operators that are used in this chapter.
    /// </summary>
    [Required] 
    public IEnumerable<OperatorModel> Operators { get; } = new List<OperatorModel>();
}