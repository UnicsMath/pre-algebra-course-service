using System.ComponentModel.DataAnnotations;
using Enum;

namespace Model;

public class OperationModel
{
    [Key]
    public MathOperations MathOperationId { get; set; }
    
    [Required]
    public string MathOperation { get; set; }
}