
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using TalkingClockRuleEngine;

namespace TalkingClockRestAPI.Controllers
{
    [ApiController]
    [Route("TalkingClock/{timeinput?}")]
    [Produces("application/json")]
    public class TalkingClockController : ControllerBase
    {
        private readonly ILogger<TalkingClockController> _logger;

        public TalkingClockController(ILogger<TalkingClockController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? timeinput)
        {

            if (timeinput is null)
            {
                string[] times = DateTime.Now.ToString("hh:mm").Split(':');
                return Ok((ConvertToWords.ConverttoWords(int.Parse(times[0]), int.Parse(times[1]))));
            }

            if (!ConvertToWords.ChecktimeFormat(timeinput)) return BadRequest("Time is not in right format");
            string[] hour = timeinput.Split(':');
            return Ok(ConvertToWords.ConverttoWords(int.Parse(hour[0]), int.Parse(hour[1])));

        }
    }
}
