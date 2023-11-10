namespace Model;

public class SubjectModel
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ChapterModel[] Chapters { get; set; }

    public SubjectModel(
        long id,
        string title,
        string description,
        ChapterModel[] chapters
        ) =>
        (Id, Title, Description, Chapters) = 
        (id, title, description, chapters);
}