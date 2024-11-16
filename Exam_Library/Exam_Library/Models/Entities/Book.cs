using System.ComponentModel.DataAnnotations;

namespace Exam_Library.Models.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public int Title { get; set; } 
        public string Description { get; set; }
        public int Publish_year { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
       
    }
}
