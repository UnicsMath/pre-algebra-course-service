using Model;
using Repository;

namespace Test;

public class CourseMock : ICourseRepository
{
    private IEnumerable<CourseModel> _courseModels;

    public CourseMock(IEnumerable<CourseModel> courseModels) => _courseModels = courseModels;

    public CourseModel GetByName(string courseName) => 
        _courseModels.Single(course => course.Name == courseName);
}