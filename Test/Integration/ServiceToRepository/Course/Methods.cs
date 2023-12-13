using Model;
using Service;
using ViewModels;

namespace Test.Integration.ServiceToRepository.Course;

[TestFixture]
public class Methods
{
    private static readonly IEnumerable<CourseModel> CourseModels = new List<CourseModel>
    {
        new()
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
        }
    };
    
    private readonly CourseService _courseService = new(new CourseMock(CourseModels));
    
    [Test]
    public void GetByName_ShouldReturnCourseIndexViewModel()
    {
        // Arrange
        const string courseName = "pre-algebra";
        CourseModel expected = CourseModels.Single(course => course.Name == courseName);
        
        // Act
        var result = _courseService.GetByCourseName(courseName);
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CourseIndexViewModel>());
            Assert.That(result.Name, Is.EqualTo(expected.Name));
            Assert.That(result.Description, Is.EqualTo(expected.Description));
            Assert.That(result.Created, Is.EqualTo(expected.Created));
            Assert.That(result.Updated, Is.EqualTo(expected.Updated));
            Assert.That(result.Author, Is.Not.Null);
            Assert.That(result.Author, Is.TypeOf<AuthorViewModel>());
            Assert.That(result.Author.Name, Is.EqualTo(expected.Author.Name));
            Assert.That(result.Author.Title, Is.EqualTo(expected.Author.Title));
            Assert.That(result.Author.Degree, Is.EqualTo(expected.Author.Degree));
            Assert.That(result.Chapters, Is.Not.Null);
            Assert.That(result.Chapters, Is.Not.Empty);
            Assert.That(result.Chapters, Is.TypeOf<string[]>());
            Assert.That(result.Chapters.Count, Is.EqualTo(expected.Chapters.Count));
            Assert.That(result.Chapters, Is.EquivalentTo(expected.Chapters.Select(chapter => chapter.Title)));
        });
    }
}