using boleto.Application.Commands.CreatePaymentBatch;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace boleto.API.Controllers;

[Route("api/batch")]
[ApiController]
public class BankSlipPaymentBatchController : ControllerBase
{
    private readonly IMediator _mediator;
    public BankSlipPaymentBatchController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("create")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Create([FromBody] CreatePaymentBatchCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}
