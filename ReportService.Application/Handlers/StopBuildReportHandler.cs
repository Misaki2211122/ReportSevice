using MediatR;
using ReportService.Application.Domains.Requests;
using ReportService.Application.Domains.Responses;

namespace ReportService.Application.Handlers;

public class StopBuildReportHandler: IRequestHandler<StopBuildReportRequest, StopBuildReportResponse>
{
    /// <summary>
    /// StopBuildReportHandler
    /// </summary>
    public StopBuildReportHandler()
    {
    }

    public async Task<StopBuildReportResponse> Handle(StopBuildReportRequest request, CancellationToken cancellationToken)
    {
        return new StopBuildReportResponse();

        /*
        if (res != 0)
            return new StopBuildReportResponse() { Success = true};
        else
            return new StopBuildReportResponse() { Success = false, Message = "Can't stop build report" };*/
    }
}