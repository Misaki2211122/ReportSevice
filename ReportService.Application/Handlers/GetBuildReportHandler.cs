using MediatR;
using ReportService.Application.Abstractions;
using ReportService.Application.Domains.Requests;
using ReportService.Application.Domains.Responses;

namespace ReportService.Application.Handlers;

public class GetBuildReportHandler: IRequestHandler<GetBuildReportRequest, GetBuildReportResponse>
{
    private readonly IReportBuilder _reportBuilder;
    /// <summary>
    /// GetBuildReportHandler
    /// </summary>
    public GetBuildReportHandler(IReportBuilder reportBuilder)
    {
        _reportBuilder = reportBuilder ?? throw new ArgumentNullException(nameof(reportBuilder));
    }

    public async Task<GetBuildReportResponse> Handle(GetBuildReportRequest request, CancellationToken cancellationToken)
    {
        _reportBuilder.Build();
        
        Guid id = Guid.NewGuid();
        
        if (id != Guid.Empty)
            return new GetBuildReportResponse() { Success = true, ReportId = id};
        else
            return new GetBuildReportResponse() { Success = false, Message = "Can't build report" };
    }
}