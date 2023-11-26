using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

[ComplexType]
public class ExpressionConfiguration
{
    public ushort MinimumLength { get; set; }
    public ushort MaximumLength { get; set; }
    public ushort MinimumConstantValue { get; set; }
    public ushort MaximumConstantValue { get; set; }
}