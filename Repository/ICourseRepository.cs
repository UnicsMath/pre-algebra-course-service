using Model;

namespace Repository;

public interface ICourseRepository
{
    CourseModel GetByName(string courseName);
}