using MediatR;
using ReportService.Application.Domains.Responses;

namespace ReportService.Application.Domains.Requests;

public class StopBuildReportRequest : IRequest<StopBuildReportResponse>
{
    public Guid ReportId { get; set; }
}