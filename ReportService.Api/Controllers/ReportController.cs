using System.ComponentModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportService.Application.Domains.Requests;
using ReportService.Application.Domains.Responses;
using Swashbuckle.AspNetCore.Annotations;

namespace ReportService.Api.Controllers;

[ApiController]
[Route("/report/")]
[DisplayName("Построение отчета")]
[Produces("application/json")]
public class ReportController: ControllerBase
{
    private readonly IMediator _mediator;

    /// <summary>
    /// ReportController
    /// </summary>
    /// <param name="mediator"></param>
    public ReportController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }
     
    /// <summary>
    /// Запустить построение отчета
    /// </summary>
    /// <param name="request">GetListAdminSettingsRequest</param>
    /// <returns></returns>
    [HttpGet]
    [Route("getBuildReport")]
    [SwaggerResponse(StatusCodes.Status200OK, "Запустить построение отчета", typeof(GetBuildReportResponse))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Запустить построение отчета", typeof(GetBuildReportResponse))]
    public async Task<IActionResult>  GetBuildReport([FromQuery] GetBuildReportRequest request)
    {
        var resp = await _mediator.Send(request);

        if (resp.Success)
            return Ok(resp);
        else
            return BadRequest(resp);
    }
    
    /// <summary>
    /// Остановить построение отчета
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("stopBuildReport")]
    [SwaggerResponse(StatusCodes.Status200OK, "Остановить построение отчета", typeof(StopBuildReportResponse))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Остановить построение отчета", typeof(StopBuildReportResponse))]
    public async Task<IActionResult> StopBuildReport([FromBody] StopBuildReportRequest request)
    {
        var resp = await _mediator.Send(request);

        if (resp.Success)
            return Ok(resp);
        else
            return BadRequest(resp);
    }
}