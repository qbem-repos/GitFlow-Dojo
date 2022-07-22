using Microsoft.AspNetCore.Mvc;
//dependência adicionada
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