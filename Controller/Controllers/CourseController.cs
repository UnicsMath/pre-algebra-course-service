using Microsoft.AspNetCore.Mvc;
using Service;
using UnitTest;
using ViewModels;

namespace Controller.Controllers;

[ApiController]
[Route("[Controller]")]
public class CourseController : ControllerBase
{
    private CourseService _courseService = new(new CourseMock());
    
    [HttpGet("{courseName}")]
    public CourseIndexViewModel GetByCourseName(string courseName) => 
        _courseService.GetByCourseName(courseName);
}   