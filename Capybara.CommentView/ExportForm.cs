using System.Windows.Forms;
using Capybara.CommentView.Interfaces;

namespace Capybara.CommentView
{
    public partial class ExportForm : Form
    {
        public ExportForm(ExportOptions exportOptions)
        {
            InitializeComponent();
            this.exportOptionsBindingSource.DataSource = exportOptions;
        }
    }
}
