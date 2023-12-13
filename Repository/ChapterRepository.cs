using Model;
using Service;

namespace Repository;

public class ChapterRepository : IChapterRepository
{
    private readonly CourseDbContext _context;
    
    public ChapterRepository(CourseDbContext context) => _context = context;
    
    public ChapterModel GetByChapterNumber(ushort chapterNumber) => 
        _context.Chapters.Single(chapter => chapter.ChapterNumber == chapterNumber);

    public bool Create(string courseName, ChapterModel chapter)
    {
        _context.Courses.Single(course => course.Name == courseName).Chapters.Add(chapter);
        return _context.SaveChanges() > 0;
    }
}