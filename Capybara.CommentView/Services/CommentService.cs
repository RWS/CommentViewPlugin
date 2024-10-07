using System;
using System.Collections.Generic;
using System.IO;
using Capybara.CommentView.Interfaces;
using Sdl.Core.Globalization;
using Sdl.ProjectAutomation.Core;
using Sdl.ProjectAutomation.FileBased;

namespace Capybara.CommentView.Services
{
    public class CommentService
    {
        private readonly ICommentExtractorService _commentExtractor;

        public CommentService(ICommentExtractorService commentExtractor)
        {
            _commentExtractor = commentExtractor;
        }

        public ProjectFileEntry GetCommentsFromProjectFile(ProjectFile projectFile)
        {
            if (!IsValidProjectFile(projectFile))
            {
                return null;
            }

            var comments = _commentExtractor.Extract(projectFile.LocalFilePath);
            foreach (var commentEntry in comments)
            {
                commentEntry.ProjectFile = projectFile;
                commentEntry.FileName = projectFile.Folder + projectFile.Name;
                if (string.IsNullOrEmpty(commentEntry.ParagraphId))
                {
                    commentEntry.ParagraphId = null;
                    commentEntry.SegmentId = null;
                    commentEntry.SourceSegment = null;
                    commentEntry.TargetSegment = null;
                    commentEntry.SourceText = null;
                    commentEntry.TargetText = null;
                }
            }

            return new ProjectFileEntry(projectFile, comments);
        }

        public List<ProjectFileEntry> GetCommentsFromProjectFiles(IEnumerable<ProjectFile> projectFiles)
        {
            var entries = new List<ProjectFileEntry>();
            foreach (var projectFile in projectFiles)
            {
                var entry = GetCommentsFromProjectFile(projectFile);
                if (entry != null)
                {
                    entries.Add(entry);
                }
            }

            return entries;
        }

        public TargetLanguageBasedProjectEntry GetCommentsFromProject(FileBasedProject project, Language targetLanguage)
        {
            var fileEntries = new List<ProjectFileEntry>();
            foreach (var projectFile in project.GetTargetLanguageFiles(targetLanguage))
            {
                var fileEntry = GetCommentsFromProjectFile(projectFile);
                if (fileEntry != null)
                {
                    fileEntries.Add(fileEntry);
                }
            }

            return new TargetLanguageBasedProjectEntry(project, targetLanguage, fileEntries);
        }


        public List<TargetLanguageBasedProjectEntry> GetCommentsFromProjects(IEnumerable<FileBasedProject> projects)
        {
            var entries = new List<TargetLanguageBasedProjectEntry>();
            foreach (var project in projects)
            {
                var info = project.GetProjectInfo();
                foreach (var targetLanguage in info.TargetLanguages)
                {
                    entries.Add(GetCommentsFromProject(project, targetLanguage));
                }
            }

            return entries;
        }

        private bool IsValidProjectFile(ProjectFile projectFile)
        {
            if (!File.Exists(projectFile.LocalFilePath))
            {
                return false;

            }
            if (!projectFile.LocalFilePath.EndsWith(".sdlxliff", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (projectFile.IsSource)
            {
                return false;
            }

            if (projectFile.Role != FileRole.Translatable)
            {
                return false;
            }

            return true;
        }
    }
}