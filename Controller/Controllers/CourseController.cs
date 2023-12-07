using Microsoft.AspNetCore.Mvc;
using Service;
using ViewModels;

namespace Controller.Controllers;

[ApiController]
[Route("[Controller]")]
public class CourseController : ControllerBase
{
    private readonly CourseService _courseService;

    public CourseController(CourseService courseService) => 
        _courseService = courseService;

    [HttpGet("{courseName}")]
    public CourseIndexViewModel GetByCourseName(string courseName) => 
        _courseService.GetByCourseName(courseName);
}   