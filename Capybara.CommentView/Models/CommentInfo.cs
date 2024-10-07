using Sdl.FileTypeSupport.Framework.NativeApi;

namespace Capybara.CommentView.Interfaces
{
    public class CommentInfo
    {
        public string Text { get; set; }
        public string Author { get; set; }
        public long? From { get; set; }
        public long? UpTo { get; set; }

        public Severity Severity { get; set; }
    }
}