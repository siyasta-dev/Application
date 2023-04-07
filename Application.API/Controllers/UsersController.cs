using Application.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsersController(ApplicationDbContext dbContext) 
        { 
            _context = dbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Users.ToList());
        }
        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            var newUser = _context.Users.Add(user);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(newUser.Entity);
        }
    }
}
