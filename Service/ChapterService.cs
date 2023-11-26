using Repository;
using ViewModels;

namespace Service;

public class ChapterService
{
    private readonly IChapterRepository _chapterRepository;
    private readonly ChapterMapper _chapterMapper = new();
    
    public ChapterService(IChapterRepository chapterRepository) => 
        _chapterRepository = chapterRepository;
    
    public PageViewModel GetByChapterName(string chapterName) => 
        _chapterMapper.MapModelToPageViewModel(_chapterRepository.GetByChapterName(chapterName));
}