using Exam_Library.Data;
using Exam_Library.Models;
using Exam_Library.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam_Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContect dbContect;

        public BooksController(ApplicationDbContect dbContext)

        {
            this.dbContect = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllBookdtls()
        {
            var AllBookDtls = dbContect.Books.ToList();
            return Ok(AllBookDtls);
        }
        [HttpPost]

        public IActionResult AddBookDtls(AddBookDtls addBookDtls)
        {
            var BooksEntity=new Book()
            {
                Title=addBookDtls.Title,
                Description =addBookDtls.Description,
                Publish_year=addBookDtls.Publish_year,
                AuthorId    =addBookDtls.AuthorId,
                CategoryId=addBookDtls.CategoryId,
            };
            dbContect.Books.Add(BooksEntity);
            dbContect.SaveChanges();
            return Ok(BooksEntity);

        }






    }
}
