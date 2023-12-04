using System.ComponentModel.DataAnnotations;
using Enum;

namespace Model;

public class OperatorModel
{
    [Key]
    public MathOperators MathOperatorId { get; set; }
    
    [Required]
    public string MathOperator { get; set; }
}