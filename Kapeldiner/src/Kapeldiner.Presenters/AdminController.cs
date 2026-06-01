using Kapeldiner.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Kapeldiner.Presenters;

[ApiController]
[Route("[controller]")]
public class AdminController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateEventDto request, CancellationToken cancellationToken)
    {
        return Ok("Event created");
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetEventsDto request, CancellationToken cancellationToken)
    {
        return Ok("Event get");
    }

    [HttpGet("{eventId:guid}")]
    public async Task<IActionResult> GetById([FromRoute]Guid eventId, CancellationToken cancellationToken)
    {
        return Ok("Event get");
    }

    [HttpPut("{eventId:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid eventId, [FromBody] UpdateEventDto request, CancellationToken cancellationToken)
    {
        return Ok("Event updated");
    }

    [HttpDelete("{eventId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid eventId, CancellationToken cancellationToken)
    {
        return Ok("Event deleted");
    }
}