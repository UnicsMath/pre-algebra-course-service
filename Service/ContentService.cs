using Model;
using Repository;

namespace Service;

public class ContentService
{
    private readonly IContentRepository _contentRepository;
    public ContentService(IContentRepository contentContentRepository) => _contentRepository = contentContentRepository;

    public ChapterModel GetContentBySubjectAndId(string subject, ushort chapter)
    {
        return _contentRepository.GetContentBySubjectAndId(subject, chapter);
    }
}