using Exam_Library.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Exam_Library.Data;
using Exam_Library.Models;
using Exam_Library.Models.Entities;

namespace Exam_Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagorysController : ControllerBase
    {
        private readonly ApplicationDbContect dbContect;

        public CatagorysController(ApplicationDbContect dbContext)

        {
            this.dbContect = dbContext;
        }

        [HttpGet]
        public IActionResult GetCatagorydtls()
        {
            var AllCatagorydtls=dbContect.Categories.ToList();
            return Ok(AllCatagorydtls);
        }

        [HttpPost]

        public IActionResult AddCatagoryDtls(AddCatagoryDtls addCatagoryDtls)
        {
            var CatagoryEntity = new Category()
            {
                CategoryName=addCatagoryDtls.CategoryName,
                Description=addCatagoryDtls.Description,

            };
            dbContect.Categories.Add(CatagoryEntity);
            dbContect.SaveChanges();
            return Ok(CatagoryEntity);

        }
    }
}
