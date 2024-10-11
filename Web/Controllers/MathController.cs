using Microsoft.AspNetCore.Mvc;

namespace testtaskwithc.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<MathController> _logger;

    public MathController(ILogger<MathController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFibonachiNumber")]
    public ActionResult<int> GetFibonachiNumber()
    {
        return Ok(5);
    }
}
