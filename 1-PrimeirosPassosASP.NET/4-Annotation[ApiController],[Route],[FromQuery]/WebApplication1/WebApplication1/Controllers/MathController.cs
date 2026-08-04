using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum);
            }
            return BadRequest("Invalid input.");
        }

        private int ConvertToDecimal(string secondNumber)
        {
            throw new NotImplementedException();
        }

        private decimal IsNumeric(string firstNumber)
        {
            throw new NotImplementedException();
        }
    }
}
