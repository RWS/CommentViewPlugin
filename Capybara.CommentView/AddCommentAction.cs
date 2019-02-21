﻿using System.Windows.Forms;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.FileTypeSupport.Framework.NativeApi;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Capybara.CommentView
{
    [Action("CapybaraCommentView_AddCommentAction", typeof(EditorController), Name = "Add_Comment_Action_Name",
        Description = "Add_Comment_Action_Description", Icon = "CommentViewPlugin_Icon")]
    [ActionLayout(typeof(TranslationStudioDefaultContextMenus.EditorDocumentContextMenuLocation), 1, DisplayType.Large)
    ]
    public class AddCommentAction : AbstractViewControllerAction<EditorController>
    {
        protected override void Execute()
        {
            var editorController = SdlTradosStudio.Application.GetController<EditorController>();
            var document = editorController.ActiveDocument;
            var activeSegmentPair = document?.ActiveSegmentPair;
            if (activeSegmentPair == null)
            {
                return;
            }

            string commentText = null;
            using (var dialog = new AddCommentForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    commentText = dialog.CommentText;
                }
            }

            if (string.IsNullOrWhiteSpace(commentText))
            {
                return;
            }

            var fromInfo = document.Selection.Source.From;
            var uptoInfo = document.Selection.Source.UpTo;
            var commentProperties = document.PropertiesFactory.CreateCommentProperties();
            var comment = document.PropertiesFactory.CreateComment(commentText, "commentview", Severity.Low);
            commentProperties.Add(comment);
            var commentMarker = document.ItemFactory.CreateCommentMarker(commentProperties);
            activeSegmentPair.Source.MoveAllItemsTo(commentMarker);
            activeSegmentPair.Source.Clear();
            activeSegmentPair.Source.Add(commentMarker);
            document.UpdateSegmentPair(activeSegmentPair);
        }
    }
}