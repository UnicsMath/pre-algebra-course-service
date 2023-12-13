using Model;
using Riok.Mapperly.Abstractions;
using ViewModels;

namespace Service;

[Mapper]
public partial class ChapterMapper
{
    public partial PageViewModel MapModelToPageViewModel(ChapterModel chapter);
    
    public partial ChapterModel MapCreateChapterViewModelToModel(CreateChapterViewModel createChapterViewModel);
}