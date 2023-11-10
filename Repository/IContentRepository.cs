using Model;

namespace Repository;

public interface IContentRepository
{
    ChapterModel GetContentBySubjectAndId(string subject, ushort chapter);
}