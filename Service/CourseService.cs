using Repository;
using ViewModels;

namespace Service;

public class CourseService
{
    private readonly ICourseRepository _courseRepository;
    private readonly CourseMapper _courseMapper = new();
    
    public CourseService(ICourseRepository courseRepository) => 
        _courseRepository = courseRepository;

    public CourseIndexViewModel GetByCourseName(string courseName) => 
        _courseMapper.MapModelToIndexViewModel(_courseRepository.GetByName(courseName));
}