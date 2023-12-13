using Model;
using Service;
using ViewModels;

namespace Test.Unit.Mapper;

[TestFixture]
public class Course
{
    private readonly CourseModel _expected = new()
    {
        CourseId = 1,
        Name = "pre-algebra",
        Description = "Learn pre-algebra for free—all of the basic arithmetic and geometry skills needed for algebra. Full curriculum of exercises and videos.",
        Created = new (2020, 1, 1, 0, 0, 0, DateTimeKind.Utc),
        Updated = new (2020, 1, 1, 0, 0, 0, DateTimeKind.Utc),
        AuthorId = 1,
        Author = new()
        {
            AuthorId = 1,
            Name = "Long",
            Title = "Dr",
            Degree = "Computer Science"
        },
        Chapters = new List<ChapterModel>
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
        }
    };
    
    [Test]
    public void ModelToView_ShouldReturnCourseIndexViewModel()
    {
        // Arrange
        CourseMapper courseMapper = new();
        
        // Act
        var result = courseMapper.MapModelToIndexViewModel(_expected);
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CourseIndexViewModel>());
            Assert.That(result.Name, Is.EqualTo(_expected.Name));
            Assert.That(result.Description, Is.EqualTo(_expected.Description));
            Assert.That(result.Created, Is.EqualTo(_expected.Created));
            Assert.That(result.Updated, Is.EqualTo(_expected.Updated));
            Assert.That(result.Author, Is.Not.Null);
            Assert.That(result.Author, Is.TypeOf<AuthorViewModel>());
            Assert.That(result.Author.Name, Is.EqualTo(_expected.Author.Name));
            Assert.That(result.Author.Title, Is.EqualTo(_expected.Author.Title));
            Assert.That(result.Author.Degree, Is.EqualTo(_expected.Author.Degree));
            Assert.That(result.Chapters, Is.Not.Null);
            Assert.That(result.Chapters, Is.Not.Empty);
            Assert.That(result.Chapters, Is.TypeOf<string[]>());
            Assert.That(result.Chapters.Count, Is.EqualTo(_expected.Chapters.Count));
            Assert.That(result.Chapters, Is.EquivalentTo(_expected.Chapters.Select(chapter => chapter.Title)));
        });
    }
}