namespace Capybara.CommentView.Interfaces
{
    public class TextElement : ISegmentElement
    {
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }
    }
}
