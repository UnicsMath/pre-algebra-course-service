using Model;
using Service;

namespace Repository;

public class CourseRepository : ICourseRepository
{
    private readonly CourseDbContext _context;
    
    public CourseRepository(CourseDbContext context) => _context = context;

    public CourseModel GetByName(string courseName)
    {
        throw new NotImplementedException();
    }
}