using Repository;
using ViewModels;

namespace Service;

public class ChapterService
{
    private readonly IChapterRepository _chapterRepository;
    private readonly ChapterMapper _chapterMapper = new();
    
    public ChapterService(IChapterRepository chapterRepository) => 
        _chapterRepository = chapterRepository;
    
    public PageViewModel GetByChapterName(ushort chapterNumber) => 
        _chapterMapper.MapModelToPageViewModel(_chapterRepository.GetByChapterName(chapterNumber));
    
    public CreateChapterViewModel Create(CreateChapterViewModel createChapterViewModel) => 
        _chapterMapper.MapModelToCreateChapterViewModel(
            _chapterRepository.Create(
                createChapterViewModel.CourseName,
                _chapterMapper.MapCreateChapterViewModelToModel(createChapterViewModel)
            )
        );
}