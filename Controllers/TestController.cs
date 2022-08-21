using exercise_app_api.Data;
using exercise_app_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace exercise_app_api.Controllers
{
    [ApiController]
    [Route("v1/categories")]
    public class TestController : Controller
    {

        public TestController (DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("test")]
        public async Task<ActionResult<TestClass>> GetTest([FromServices] DataContext context)
        {
            var result = await context.Users.ToListAsync();
            return Ok(result);
        }

        private readonly DataContext _context;
    }
}