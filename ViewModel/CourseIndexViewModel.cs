namespace ViewModels;

public record CourseIndexViewModel(
    string Name,
    string Description,
    string[] Chapters,
    DateTime Created,
    DateTime Updated,
    AuthorViewModel Author)
{
    public string[] Chapters { get; set; } = Chapters;
}