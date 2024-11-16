using System.ComponentModel.DataAnnotations;

namespace Exam_Library.Models.Entities
{
    public class Author
    {
        [Key]
        public int Author_Id {  get; set; }
        public string AuthorName { get; set; }
        public string Bio { get; set; }
    }
}
