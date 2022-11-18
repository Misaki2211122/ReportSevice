namespace ReportService.Application.Abstractions;

public interface IReportBuilder
{
    public Task<byte[]> Build();
}