using Microsoft.AspNetCore.Mvc;
using Model;
using Service;
using UnitTest;

namespace Controller.Controllers;

[ApiController]
[Route("[Controller]")]
public class ContentController : ControllerBase
{
    private ContentService _contentService = new(new ContentMock());
    
    [HttpGet("{subjectTitle}/{chapterId}")]
    public ChapterModel GetContentBySubjectAndId(string subjectTitle, ushort chapterId)
    {
        return _contentService.GetContentBySubjectAndId(subjectTitle, chapterId);
    }
}   