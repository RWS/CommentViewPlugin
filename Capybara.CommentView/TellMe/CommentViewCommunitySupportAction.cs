using Sdl.TellMe.ProviderApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capybara.CommentView.TellMe
{
    public class CommentViewCommunitySupportAction : AbstractTellMeAction
    {
        public CommentViewCommunitySupportAction()
        {
            Name = "RWS Community AppStore Forum";
        }

        public override string Category => $"{PluginResources.Plugin_Name} results";

        public override bool IsAvailable => true;

        public override Icon Icon => PluginResources.CommentView_Question;

        public override void Execute()
        {
            Process.Start("https://appstore.rws.com/Plugin/274?tab=support");
        }
    }
}
