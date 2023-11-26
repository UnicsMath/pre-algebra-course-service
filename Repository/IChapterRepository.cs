using Model;

namespace Repository;

public interface IChapterRepository
{
    ChapterModel GetByChapterName(string chapterName);
}