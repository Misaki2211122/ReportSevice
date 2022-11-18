namespace ReportService.Application.Domains.Responses;

public class GetBuildReportResponse : BasicResponse
{
    public Guid ReportId { get; set; }
    
}