using System;
using System.Threading.Tasks;
using exercise_app_api.Data;
using exercise_app_api.Models;
using Microsoft.AspNetCore.Mvc;

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
            var user = new TestClass()
            {
                Id = 1,
                FirstName = "FirstName",
                LastName = "LastName",
                CreatedOn = DateTime.UtcNow,
                Username = "username2022"
            };
            // var result = await context.Users.ToListAsync();
            return Ok(user);
        }

        private readonly DataContext _context;
    }
}