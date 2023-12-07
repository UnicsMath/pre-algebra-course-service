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
    public PageViewModel GetByChapterName(ushort chapterNumber) => 
        _chapterService.GetByChapterName(chapterNumber);
    
    [HttpPost("Add")]
    public CreateChapterViewModel Create(CreateChapterViewModel createChapterViewModel) => 
        _chapterService.Create(createChapterViewModel);
}