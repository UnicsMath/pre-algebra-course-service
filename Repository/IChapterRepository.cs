using Model;

namespace Repository;

public interface IChapterRepository
{
    ChapterModel GetByChapterNumber(ushort chapterNumber);
    bool Create(string courseName, ChapterModel chapter);
}