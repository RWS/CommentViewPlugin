using System.Collections.Generic;
using System.Linq;
using Sdl.Core.Globalization;
using Sdl.ProjectAutomation.FileBased;

namespace Capybara.CommentView.Interfaces
{
    public class TargetLanguageBasedProjectEntry 
    {
        public TargetLanguageBasedProjectEntry()
        {
            ProjectFileEntries = new List<ProjectFileEntry>();
        }
        public TargetLanguageBasedProjectEntry(FileBasedProject project, Language targetLanguage, IEnumerable<ProjectFileEntry> projectFileEntries)
        {
            Project = project;
            var info = project.GetProjectInfo();
            ProjectName = info.Name;
            TargetLanguage = targetLanguage;
            TargetLanguageCode = targetLanguage.IsoAbbreviation;
            ProjectFileEntries = new List<ProjectFileEntry>(projectFileEntries);
            CommentsCount = ProjectFileEntries.Sum(x => x.CommentsCount);
        }

        public List<ProjectFileEntry> ProjectFileEntries { get; }

        public FileBasedProject Project { get; }

        public string ProjectName { get; }

        public Language TargetLanguage { get; }

        public string TargetLanguageCode { get; }

        public int CommentsCount { get; }


    }
}