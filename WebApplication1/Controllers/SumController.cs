using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApplication1.Controllers
{
    [Route("api/CalculateSum")]
    [ApiController]
    public class SumController : ControllerBase
    {

         [HttpPost]
         
         public IActionResult CreateNumber(NumberInput numberInput)
        {
            if (numberInput == null)

            {
                return BadRequest();
            }
            return Ok(numberInput.Num1 + numberInput.Num2);

        }
        //return Ok({sum1 + sum2})


    }
}
