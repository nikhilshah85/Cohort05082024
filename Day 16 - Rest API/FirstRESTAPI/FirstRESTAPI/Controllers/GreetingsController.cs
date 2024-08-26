using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRESTAPI.Controllers
{
    [Route("api/[controller]")] //this are called as Attributes
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        //format of code


        //3. we need to specify what this method is doing ? out of CRUD activity
        [HttpGet]
        [Route("/greet")] //this is how this method will be accssed
        public IActionResult Greetings() //1. return type will always be IActionResult -- 100's of method but same return type
        {

            return Ok("Hello And Welcome to My Web API");
            //2.
            //return HttpStatus Code
            //there are 24 standard statud code by W3C for Http
        }


        [HttpGet]
        [Route("/greet/{guestName}")]
        public IActionResult Greetings(string guestName)
        {
            //business logic, validate value, format, calculations, DB activity etc...
            return Ok("Hello " + guestName);
        }

        [HttpGet]
        [Route("/add/{num1}/{num2}")]
        public IActionResult AddNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return Ok(result);
        }



    }
}






