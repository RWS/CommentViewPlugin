using Capybara.CommentView.Interfaces;
using System.Collections.Generic;

namespace Capybara.CommentView.Services
{
    public interface ICommentExtractorService
    {
        List<CommentEntry> Extract(string projectFilePath);
    }
}