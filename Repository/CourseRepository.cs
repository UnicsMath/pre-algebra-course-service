using Microsoft.EntityFrameworkCore;
using Model;
using Service;

namespace Repository;

public class CourseRepository : ICourseRepository
{
    private readonly CourseDbContext _context;
    
    public CourseRepository(CourseDbContext context) => _context = context;

    public CourseModel GetByName(string courseName) => 
        _context.Courses.Include(course => course.Author).Include(course => course.Chapters).Single(courses => courses.Name == courseName);
}