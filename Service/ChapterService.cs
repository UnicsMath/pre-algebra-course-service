using Repository;
using ViewModels;

namespace Service;

public class ChapterService
{
    private readonly IChapterRepository _chapterRepository;
    private readonly ChapterMapper _chapterMapper = new();
    
    public ChapterService(IChapterRepository chapterRepository) => 
        _chapterRepository = chapterRepository;
    
    public PageViewModel GetByChapterNumber(ushort chapterNumber) => 
        _chapterMapper.MapModelToPageViewModel(_chapterRepository.GetByChapterNumber(chapterNumber));

    public bool Create(CreateChapterViewModel createChapterViewModel) =>
        _chapterRepository.Create(
            createChapterViewModel.CourseName,
            _chapterMapper.MapCreateChapterViewModelToModel(createChapterViewModel)
        );
}