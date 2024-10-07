using System.Collections.Generic;
using Sdl.ProjectAutomation.Core;

namespace Capybara.CommentView.Interfaces
{
    public class ProjectFileEntry
    {
        public ProjectFileEntry(ProjectFile projectFile, IEnumerable<CommentEntry> comments)
        {
            ProjectFile = projectFile;
            FileName = projectFile.Folder + projectFile.Name;
            Comments = new List<CommentEntry>(comments);
            CommentsCount = Comments.Count;
        }


        public ProjectFile ProjectFile { get; }

        public string FileName { get; }

        public List<CommentEntry> Comments { get; }

        public int CommentsCount { get; }


    }
}
