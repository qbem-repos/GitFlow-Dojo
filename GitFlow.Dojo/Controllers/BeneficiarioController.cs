using Microsoft.AspNetCore.Mvc;

namespace GitFlow.Dojo.Controllers;

[ApiController]
[Route("[controller]")]
public class BeneficiarioController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        await Task.CompletedTask;
        return NoContent();
    }
}