using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Capybara.CommentView.Interfaces
{
    abstract public class ModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        abstract public string Error { get; }

        protected readonly Dictionary<string, string> _errors = new Dictionary<string, string>();
        public string this[string columnName]
        {
            get
            {
                return _errors.ContainsKey(columnName) ? _errors[columnName] : null;
            }
        }
    }
}
