using System.Collections.ObjectModel;
using Microsoft.VisualBasic.CompilerServices;
using Model;
using Repository;
using Enum;

namespace UnitTest;

public class ContentMock : IContentRepository
{
    private IEnumerable<SubjectModel> _subjectModels = new SubjectModel[]
    {
        new(1,
            "addition",
            "Learn addition",
            new ChapterModel[]
            {
                new(1,
                    "Basics",
                    "Core principles",
                    new(2,
                        2,
                        0,
                        9,
                        new[]
                        {
                            MathOperators.Addition
                        }
                    )
                )
            }
        )
    };
        
    public ChapterModel GetContentBySubjectAndId(string subjectTitle, ushort chapterId)
    {
        return _subjectModels.Single(model => model.Title == subjectTitle).Chapters.Single(chapter => chapter.Id == chapterId);
    }
}