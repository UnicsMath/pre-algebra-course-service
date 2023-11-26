using System.ComponentModel.DataAnnotations;
using Enum;

namespace Model;

public class OperatorModel
{
    [Key]
    public MathOperators MathOperator { get; set; }
}