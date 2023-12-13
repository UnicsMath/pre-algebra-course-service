using Enum;
using Model;
using Service;
using ViewModels;

namespace Test.Unit.Mapper;

[TestFixture]
public class Chapter
{
    private readonly ChapterModel _expectedModel = new()
    {
        ChapterId = 1,
        ChapterNumber = 1,
        Title = "Introduction to Algebra",
        Content = "Learn the basics of algebra for free—focused on common mathematical relationships, such as linear relationships. Full curriculum of exercises and videos.",
        MinimumLength = 2,
        MaximumLength = 4,
        MinimumConstantValue = 0,
        MaximumConstantValue = 200,
        Operations = new List<OperationModel>
        {
            new()
            {
                MathOperationId = 1,
                MathOperation = MathOperations.Addition.ToString()
            },
            new()
            {
                MathOperationId = 2,
                MathOperation = MathOperations.Subtraction.ToString()
            }
        }
    };
    
    private readonly PageViewModel _expectedPageViewModel = new(
        1,
        "Introduction to Algebra",
        "Learn the basics of algebra for free—focused on common mathematical relationships, such as linear relationships. Full curriculum of exercises and videos."
    );    
    
    private readonly CreateChapterViewModel _expectedCreateChapterViewModel = new(
        "pre-algebra",
        1,
        "Introduction to Algebra",
        "Learn the basics of algebra for free—focused on common mathematical relationships, such as linear relationships. Full curriculum of exercises and videos.",
        2,
        4,
        0,
        200,
        new List<OperationViewModel>
        {
            new(MathOperations.Addition.ToString()),
            new(MathOperations.Subtraction.ToString())
        }
    );
    
    [Test]
    public void ModelToView_ShouldReturnPageViewModel()
    {
        // Arrange
        ChapterMapper chapterMapper = new();
        
        // Act
        var result = chapterMapper.MapModelToPageViewModel(_expectedModel);
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<PageViewModel>());
            Assert.That(result.ChapterNumber, Is.EqualTo(_expectedPageViewModel.ChapterNumber));
            Assert.That(result.Title, Is.EqualTo(_expectedPageViewModel.Title));
            Assert.That(result.Content, Is.EqualTo(_expectedPageViewModel.Content));
        });
    }
    
    [Test]
    public void ViewToModel_ShouldReturnChapterModel()
    {
        // Arrange
        ChapterMapper chapterMapper = new();
        
        // Act
        var result = chapterMapper.MapCreateChapterViewModelToModel(_expectedCreateChapterViewModel);
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ChapterModel>());
            Assert.That(result.ChapterNumber, Is.EqualTo(_expectedModel.ChapterNumber));
            Assert.That(result.Title, Is.EqualTo(_expectedModel.Title));
            Assert.That(result.Content, Is.EqualTo(_expectedModel.Content));
        });
    }
}