namespace Exam_Library.Models
{
    public class AddBookDtls
    {
        public int Title { get; set; }
        public string Description { get; set; }
        public int Publish_year { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
