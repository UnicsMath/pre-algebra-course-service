using Enum;

namespace ViewModels;

public record CreateChapterViewModel(
    string CourseName,
    ushort ChapterNumber, 
    string Title, 
    string Content, 
    ushort MinimumLength, 
    ushort MaximumLength, 
    ushort MinimumConstantValue, 
    ushort MaximumConstantValue, 
    IEnumerable<OperationViewModel> Operations
);