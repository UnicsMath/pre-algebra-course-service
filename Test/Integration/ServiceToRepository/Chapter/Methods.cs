using Enum;
using Model;
using Service;
using ViewModels;

namespace Test.Integration.ServiceToRepository.Chapter;

[TestFixture]
public class Methods
{
    private static readonly ICollection<ChapterModel> ChapterModels = new List<ChapterModel>
    {
        new()
        {
            ChapterId = 1,
            ChapterNumber = 1,
            Title = "Introduction to Algebra",
            Content = "Learn the basics of algebra for free—focused on common mathematical relationships, such as linear relationships. Full curriculum of exercises and videos."
        },
        new()
        {
            ChapterId = 2,
            ChapterNumber = 2,
            Title = "Linear Equations & Inequalities",
            Content = "Learn how to solve linear equations that contain a single variable. For example, solve 2(x+3)=(4x-1)/2+7."
        }
    };
    
    private readonly ChapterService _courseService = new(new ChapterMock(ChapterModels));
    
    [Test]
    public void GetByChapterNumber_ShouldReturnPageViewModel(
        [Values(1, 2)] short chapterNumber
        )
    {
        // Arrange
        ChapterModel expected = ChapterModels.Single(chapter => chapter.ChapterNumber == chapterNumber);
        
        // Act
        var result = _courseService.GetByChapterNumber((ushort)chapterNumber);
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<PageViewModel>());
            Assert.That(result.ChapterNumber, Is.EqualTo(expected.ChapterNumber));
            Assert.That(result.Title, Is.EqualTo(expected.Title));
            Assert.That(result.Content, Is.EqualTo(expected.Content));
        });
    }
    
    [Test]
    public void Create_ShouldReturnTrue(
        [Values("pre-algebra", "calculus-volume-1")] string courseName,
        [Values(3, 4)] short chapterNumber,
        [Values("Introduction to Algebra", "Linear Equations & Inequalities")] string title,
        [Values("Learn the basics of algebra for free—focused on common mathematical relationships, such as linear relationships. Full curriculum of exercises and videos.", "Learn how to solve linear equations that contain a single variable. For example, solve 2(x+3)=(4x-1)/2+7.")] string content,
        [Values(2, 3)] short minimumLength,
        [Values(4, 5)] short maximumLength,
        [Values(0, 1)] short minimumConstantValue,
        [Values(200, 201)] short maximumConstantValue,
        [Values(MathOperations.Addition, MathOperations.Subtraction)] MathOperations mathOperation
        )
    {
        // Arrange
        CreateChapterViewModel createChapterViewModel = new
        (
            courseName,
            (ushort)chapterNumber,
            title,
            content,
            (ushort)minimumLength,
            (ushort)maximumLength,
            (ushort)minimumConstantValue,
            (ushort)maximumConstantValue,
            new List<OperationViewModel>
            {
                new(mathOperation.ToString())
            }
        );
        
        // Act
        var result = _courseService.Create(createChapterViewModel);
        
        // Assert
        Assert.That(result, Is.TypeOf<bool>());
        Assert.That(result, Is.True);
    }
}