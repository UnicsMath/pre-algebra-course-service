using Model;
using Repository;

namespace Test;

public class ChapterMock : IChapterRepository
{
    private ICollection<ChapterModel> _chapterModels;
    
    public ChapterMock(ICollection<ChapterModel> chapterModels) => _chapterModels = chapterModels;

    public ChapterModel GetByChapterNumber(ushort chapterNumber) => 
        _chapterModels.Single(chapter => chapter.ChapterNumber == chapterNumber);

    public bool Create(string courseName, ChapterModel chapter)
    {
        _chapterModels.Add(chapter);
        return _chapterModels.Contains(chapter);
    }
}