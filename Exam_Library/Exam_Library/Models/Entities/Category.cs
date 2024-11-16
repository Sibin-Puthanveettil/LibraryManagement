using System.ComponentModel.DataAnnotations;

namespace Exam_Library.Models.Entities
{
    public class Category
    {
        [Key]
        public int CatagoryId { get; set; }
        public int CategoryName { get; set; }
        public string Description { get; set; }
    }
}
