using Model;
using Repository;

namespace UnitTest;

public class ChapterMock : IChapterRepository
{
    private readonly IEnumerable<ChapterModel> _chapterModels = new List<ChapterModel>
    {
        new()
        {
            ChapterId = 1,
            ChapterNumber = 1,
            Title = "Introduction to Algebra",
            Description = "Learn the basics of algebra for free—focused on common mathematical relationships, such as linear relationships. Full curriculum of exercises and videos."
        },
        new()
        {
            ChapterId = 2,
            ChapterNumber = 2,
            Title = "Linear Equations & Inequalities",
            Description = "Learn how to solve linear equations that contain a single variable. For example, solve 2(x+3)=(4x-1)/2+7."
        }
    };

    public ChapterModel GetByChapterName(ushort chapterNumber) => 
        _chapterModels.Single(chapter => chapter.ChapterNumber == chapterNumber);
}