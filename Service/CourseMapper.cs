using Model;
using Riok.Mapperly.Abstractions;
using ViewModels;

namespace Service;

[Mapper]
public partial class CourseMapper
{    
    public CourseIndexViewModel MapModelToIndexViewModel(CourseModel course)
    {
        CourseIndexViewModel viewModel = ModelToIndexViewModel(course);
        viewModel.Chapters = course.Chapters.Select(chapter => chapter.Title).ToArray();
        return viewModel;
    }
    
    [MapperIgnoreTarget(nameof(CourseIndexViewModel.Chapters))]
    private partial CourseIndexViewModel ModelToIndexViewModel(CourseModel course);
}