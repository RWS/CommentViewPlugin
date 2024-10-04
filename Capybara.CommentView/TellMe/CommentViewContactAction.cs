using Sdl.TellMe.ProviderApi;
using System.Diagnostics;
using System.Drawing;

namespace Capybara.CommentView.TellMe
{
    public class CommentViewContactAction : AbstractTellMeAction
    {
        public CommentViewContactAction()
        {
            Name = "Comment View Plugin - Trados Documentation";
        }

        public override string Category => $"{PluginResources.Plugin_Name} results";

        public override Icon Icon => PluginResources.CommentView_Documentation;
        
        public override bool IsAvailable => true;

        public override void Execute()
        {
            Process.Start("https://appstore.rws.com/Plugin/274?tab=documentation");
        }
    }
}
