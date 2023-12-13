using System.ComponentModel.DataAnnotations;
using Enum;

namespace Model;

public class OperationModel
{
    [Key]
    public byte MathOperationId { get; set; }
    
    [Required]
    public string MathOperation { get; set; }
}