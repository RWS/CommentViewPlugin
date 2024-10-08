﻿using System;
using System.Threading.Tasks;
using Capybara.CommentView.Services;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.Desktop.IntegrationApi.Interfaces;
using Sdl.TranslationStudioAutomation.IntegrationApi;

namespace Capybara.CommentView
{
    [ViewPart(
        Id = "FilesCommentViewPart",
        Name = "Plugin_Name",
        Description = "Plugin_Description",
        Icon = "commentView_Logo")]
    [ViewPartLayout(typeof(FilesController), Dock = DockType.Bottom)]
    class FilesCommentViewPartController : AbstractViewPartController
    {
        private readonly CommentService _commentService = new CommentService(new CommentExtractorService());

        protected override IUIControl GetContentControl()
        {
            return Control.Value;
        }

        protected override void Initialize()
        {
            var filesController = SdlTradosStudio.Application.GetController<FilesController>();

            filesController.SelectedFilesChanged += async (sender, args) =>
            {
                Control.Value.ShowLoadingProgressBar(true);
                var result = await Task.Run(() =>
                {
                    return _commentService.GetCommentsFromProjectFiles(filesController.SelectedFiles);
                });
                Control.Value.SetContent(result);
                Control.Value.ShowLoadingProgressBar(false);
            };

        }


        private static readonly Lazy<FilesCommentViewPartControl> Control = new Lazy<FilesCommentViewPartControl>(() => new FilesCommentViewPartControl());
    }
}
