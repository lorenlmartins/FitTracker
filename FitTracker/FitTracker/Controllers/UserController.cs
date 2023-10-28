using FitTracker.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FitTracker.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpPost]
        public IActionResult Create(string name, string email, string password)
        {
            var user = new User(name, email, password);
            return Ok("Created with success");
        }
    }
}
