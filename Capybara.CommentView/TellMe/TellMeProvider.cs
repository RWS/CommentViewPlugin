using Sdl.TellMe.ProviderApi;

namespace Capybara.CommentView.TellMe
{
    [TellMeProvider]
    public class TellMeProvider : ITellMeProvider
    {
        public string Name => "Comment View provider";

        public AbstractTellMeAction[] ProviderActions => new AbstractTellMeAction[]
        {
            new CommentViewContactAction()
            {
                Keywords = new [] { 
                    "commentview", "comment view", "commentview documentation", "comment view documentation",
                    "commentview plugin", "comment view plugin", "commentview trados", "comment view trados" }
            },

            new CommentViewCommunitySupportAction()
            {
                Keywords = new[]
                {
                    "commentview", "comment view", "commentview community", "comment view community",
                    "commentview support", "comment view support", "commentview appstore", "comment view appstore",
                    "commentview forum", "comment view forum" 
                }
            },

            new CommentViewSourceCodeAction()
            {
                Keywords = new[]
                {
                    "commentview", "comment view", "commentview source", "comment view source",
                    "commentview source code", "comment view source code", "commentview plugin", 
                    "comment view plugin", "comment view trados", "commentview trados"
                }
            },

            new CommentViewFilesViewAction()
            {
                Keywords = new[]
                {
                    "commentview", "comment view", "commentview plugin", "comment view plugin",
                    "commentview trados", "comment view trados"
                }
            }
        };
    }
}
