using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace testtaskwithc.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private readonly ILogger<MathController> _logger;
    private readonly IMathService _mathService;

    public MathController(
        ILogger<MathController> logger,
        IMathService mathService)
    {
        _logger = logger;
        _mathService = mathService;
    }

    [HttpGet(Name = "GetFibonachiNumber")]
    public ActionResult<int> GetFibonachiNumber(int n)
    {
        try
        {
            int fibonachiResult = _mathService.GetFibonachi(n);
            return Ok(fibonachiResult);
        }
        catch(Exception ex)
        {
            _logger.LogError(ex.Message);
            return BadRequest("При выполнении операции произошла ошибка.");
        }
    }
}
