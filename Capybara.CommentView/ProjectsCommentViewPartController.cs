using System;
using System.Windows.Forms;
using Capybara.CommentView.Services;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.Desktop.IntegrationApi.Interfaces;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Task = System.Threading.Tasks.Task;

namespace Capybara.CommentView
{
    [ViewPart(
        Id = "ProjectsCommentViewPart",
        Name = "Plugin_Name",
        Description = "Plugin_Description",
        Icon = "commentView_Logo")]
    [ViewPartLayout(typeof(ProjectsController), Dock = DockType.Bottom)]
    public class ProjectsCommentViewPartController : AbstractViewPartController
    {
        private readonly CommentService _commentService = new CommentService(new CommentExtractorService());

        protected override void Initialize()
        {
            var projectController = SdlTradosStudio.Application.GetController<ProjectsController>();
            projectController.SelectedProjectsChanged += async (sender, args) =>
            {
                Control.Value.ShowLoadingProgressBar(true);
                var result = await Task.Run(() =>
                {
                    return _commentService.GetCommentsFromProjects(projectController.SelectedProjects);
                });

                Control.Value.SetContent(result);
                Control.Value.ShowLoadingProgressBar(false);
            };
        }

        protected override IUIControl GetContentControl()
        {
            return Control.Value;
        }

        private static readonly Lazy<ProjectsCommentViewPartControl> Control = new Lazy<ProjectsCommentViewPartControl>(() => new ProjectsCommentViewPartControl());

    }
}