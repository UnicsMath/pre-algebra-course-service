using Model;
using Repository;

namespace UnitTest;

public class CourseMock : ICourseRepository
{
    private readonly IEnumerable<CourseModel> _courseModels = new CourseModel[]
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
                Title = "Dr.",
                Degree = "Computer Science"
            },
            Chapters = new List<ChapterModel>
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
            }
        }
    };

    public CourseModel GetByName(string courseName) => 
        _courseModels.Single(course => course.Name == courseName);
}