namespace Model;

public record ChapterModel(
    ushort Id, 
    string Title, 
    string Description,
    ExpressionConfigurationModel ExpressionConfigurationModel
    );