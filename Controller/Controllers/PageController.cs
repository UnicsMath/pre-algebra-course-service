using Microsoft.AspNetCore.Mvc;
using Service;
using ViewModels;

namespace Controller.Controllers;

[ApiController]
[Route("[Controller]")]
public class PageController : ControllerBase
{
    private readonly ChapterService _chapterService;

    public PageController(ChapterService chapterService) => 
        _chapterService = chapterService;

    [HttpGet("{chapterNumber}")]
    public PageViewModel GetByChapterNumber(ushort chapterNumber) => 
        _chapterService.GetByChapterNumber(chapterNumber);
    
    [HttpPost("Add")]
    public bool Create(CreateChapterViewModel createChapterViewModel) => 
        _chapterService.Create(createChapterViewModel);
}