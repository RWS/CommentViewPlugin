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
    internal class CommentViewSourceCodeAction : AbstractTellMeAction
    {
        public CommentViewSourceCodeAction()
        {
            Name = "Comment View Plugin - Trados Source Code";
        }

        public override string Category => $"{PluginResources.Plugin_Name} results";

        public override Icon Icon => PluginResources.CommentView_SourceCode;

        public override bool IsAvailable => true;

        public override void Execute()
        {
            Process.Start("https://github.com/RWS/CommentViewPlugin");
        }
    }
}
