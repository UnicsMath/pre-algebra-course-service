using Microsoft.VisualBasic.CompilerServices;
using Enum;

namespace Model;

public class ExpressionConfigurationModel
{
    public ushort MinimumLength { get; set; }
    public ushort MaximumLength { get; set; }
    public ushort MinimumConstantValue { get; set; }
    public ushort MaximumConstantValue { get; set; }
    public IEnumerable<MathOperators> Operators { get; set; }
    
    public ExpressionConfigurationModel(
        ushort minimumLength,
        ushort maximumLength,
        ushort minimumConstantValue,
        ushort maximumConstantValue,
        IEnumerable<MathOperators> operators
    ) =>
        (MinimumLength, MaximumLength, MinimumConstantValue, MaximumConstantValue, Operators) =
        (minimumLength, maximumLength, minimumConstantValue, maximumConstantValue, operators);
}