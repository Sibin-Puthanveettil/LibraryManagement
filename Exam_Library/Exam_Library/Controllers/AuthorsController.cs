using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exam_Library.Data;
using Exam_Library.Models;
using Exam_Library.Models.Entities;

namespace Exam_Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly ApplicationDbContect dbContect;

        public AuthorsController(ApplicationDbContect dbContext)
        {
            this.dbContect = dbContext;
        }
        [HttpGet]
        public IActionResult Getauthor_dtls()
        {
            var Allauthordtls = dbContect.Authors.ToList();
            return Ok(Allauthordtls);
        }

        [HttpPost]

        public IActionResult AddAuthorDtls(AddAuthor_dtls addAuthor_Dtls)
        {
            var AutherEntity = new Author()
            {
                AuthorName = addAuthor_Dtls.AuthorName,
                Bio = addAuthor_Dtls.Bio,
          
            };
            dbContect.Authors.Add(AutherEntity);
            dbContect.SaveChanges();
            return Ok(AutherEntity);
        }
    }
}
