namespace Capybara.CommentView.Interfaces
{
	public class ExportOptions : ModelBase
	{
		private bool _file;

		private bool _segmentId;

		private bool _comment;

		private bool _author;

		private bool _date;

		private bool _severity;

		private bool _version;

		private bool _source;

		private bool _target;

		private bool _comments;

		private bool _file2;

		public bool File
		{
			get
			{
				return _file;
			}
			set
			{
				_file = value;
				OnPropertyChanged("File");
			}
		}

		public bool SegmentId
		{
			get
			{
				return _segmentId;
			}
			set
			{
				_segmentId = value;
				OnPropertyChanged("SegmentId");
			}
		}

		public bool Comment
		{
			get
			{
				return _comment;
			}
			set
			{
				_comment = value;
				OnPropertyChanged("Comment");
			}
		}

		public bool Author
		{
			get
			{
				return _author;
			}
			set
			{
				_author = value;
				OnPropertyChanged("Author");
			}
		}

		public bool Date
		{
			get
			{
				return _date;
			}
			set
			{
				_date = value;
				OnPropertyChanged("Date");
			}
		}

		public bool Severity
		{
			get
			{
				return _severity;
			}
			set
			{
				_severity = value;
				OnPropertyChanged("Severity");
			}
		}

		public bool Version
		{
			get
			{
				return _version;
			}
			set
			{
				_version = value;
				OnPropertyChanged("Version");
			}
		}

		public bool Source
		{
			get
			{
				return _source;
			}
			set
			{
				_source = value;
				OnPropertyChanged("Source");
			}
		}

		public bool Target
		{
			get
			{
				return _target;
			}
			set
			{
				_target = value;
				OnPropertyChanged("Target");
			}
		}

		public bool Comments
		{
			get
			{
				return _comments;
			}
			set
			{
				_comments = value;
				OnPropertyChanged("Comments");
			}
		}

		public bool File2
		{
			get
			{
				return _file2;
			}
			set
			{
				_file2 = value;
				OnPropertyChanged("File2");
			}
		}

		public override string Error
		{
			get
			{
				return null;
			}
		}

		public ExportOptions()
		{
			File = true;
			SegmentId = true;
			Comment = true;
			Author = true;
			Date = true;
			Severity = true;
			Version = true;
			Source = true;
			Target = true;
			Comments = true;
			File = true;
			File2 = true;
		}
	}
}
