using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TellMe.ProviderApi;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capybara.CommentView.TellMe
{
    public class CommentViewFilesViewAction : AbstractTellMeAction
    {
        public CommentViewFilesViewAction()
        {
            Name = "Comment View Plugin - Trados Settings";
        }

        public override string Category => $"{PluginResources.Plugin_Name} results";

        public override Icon Icon => PluginResources.CommentView_Settings;

        public override bool IsAvailable => SdlTradosStudio.Application.GetController<FilesController>().CurrentProject != null;

        public override void Execute()
        {
            SdlTradosStudio.Application.GetController<FilesController>().Activate();
            SdlTradosStudio.Application.GetController<FilesCommentViewPartController>().Activate();
        }
    }
}
