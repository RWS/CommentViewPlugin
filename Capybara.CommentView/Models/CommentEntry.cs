using System.Collections.Generic;
using Sdl.ProjectAutomation.Core;

namespace Capybara.CommentView.Interfaces
{
    public class CommentEntry 
    {

        public ProjectFile ProjectFile { get; set; }


        public string FileName { get; set; }

        public string Id { get; set; }


        public string Text { get; set; }

        public string Author { get; set; }


        public string Date { get; set; }


        public string Severity { get; set; }


        public string Version { get; set; }


        public string ParagraphId { get; set; }


        public string SegmentId { get; set; }


        public List<ISegmentElement> SourceSegment { get; set; }


        public string SourceText { get; set; }


        public List<ISegmentElement> TargetSegment { get; set; }


        public string TargetText { get; set; }

    }
}