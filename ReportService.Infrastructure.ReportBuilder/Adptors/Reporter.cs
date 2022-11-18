using ReportService.Application.Abstractions;

namespace ReportService.Infrastructure.ReportBuilder.Adptors;

public class Reporter : IReporter
{
    public void ReportSuccess(byte[] Data, int Id)
    {
        throw new NotImplementedException();
    }

    public void ReportError(int Id)
    {
        throw new NotImplementedException();
    }

    public void ReportTimeout(int Id)
    {
        throw new NotImplementedException();
    }
}