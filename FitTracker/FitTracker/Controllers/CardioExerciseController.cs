using FitTracker.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FitTracker.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CardioExerciseController : ControllerBase
    {
        public CardioExerciseController()
        {

        }

        [HttpPost]
        public IActionResult Create(string name, int durationTime)
        {
            var cardioExercise = new CardioExercise(name, durationTime);
            return Ok("Created with success");
        }

    }
}