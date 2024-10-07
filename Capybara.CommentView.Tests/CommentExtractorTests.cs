using Capybara.CommentView.Interfaces;
using Capybara.CommentView.Services;

namespace Capybara.CommentView.Tests
{
    public class CommentExtractorTests
    {
        private readonly ICommentExtractorService _commentExtractorService;
        private readonly string _testingFilesPath = Path.Combine($"{Directory.GetCurrentDirectory()}", "TestingFiles");

        public CommentExtractorTests()
        {
            _commentExtractorService = new CommentExtractorService();
        }

        [Fact]
        public void Extract_FileHasComments_ReturnsListOfComents()
        {
            // Arrange
            var filePath = $"{_testingFilesPath}/sample.txt.sdlxliff";
            var commentEntries = new List<CommentEntry>();

            // Act
            commentEntries = _commentExtractorService.Extract(filePath);

            // Assert
            Assert.Equal(2, commentEntries.Count);
            Assert.NotNull(commentEntries);
        }

        [Fact]
        public void Extract_FileHasNoComments_ReturnsAnEmptyList()
        {
            // Arrange
            var filePath = $"{_testingFilesPath}/sample2.txt.sdlxliff";

            // Act
            var commentEntries = _commentExtractorService.Extract(filePath);

            // Assert
            Assert.NotNull(commentEntries);
            Assert.Equal(0, commentEntries.Count);
        }
    }
}