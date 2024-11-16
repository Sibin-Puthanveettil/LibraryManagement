using Exam_Library.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam_Library.Data
{
    public class ApplicationDbContect: DbContext
    {
        public ApplicationDbContect(DbContextOptions<ApplicationDbContect>options):base(options)

        {
            
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category>Categories { get; set; }


    }
}
