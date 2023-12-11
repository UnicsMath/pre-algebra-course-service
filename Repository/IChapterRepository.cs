using Model;

namespace Repository;

public interface IChapterRepository
{
    ChapterModel GetByChapterName(ushort chapterNumber);
    ChapterModel Create(string courseName, ChapterModel chapter);
}