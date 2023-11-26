using Microsoft.AspNetCore.Mvc;
using Service;
using UnitTest;
using ViewModels;

namespace Controller.Controllers;

[ApiController]
[Route("[Controller]")]
public class PageController : ControllerBase
{
    private ChapterService _chapterService = new(new ChapterMock());
    
    [HttpGet("{chapterName}")]
    public PageViewModel GetByChapterName(string chapterName) => 
        _chapterService.GetByChapterName(chapterName);
}