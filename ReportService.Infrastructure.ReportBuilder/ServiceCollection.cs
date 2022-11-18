using Microsoft.Extensions.DependencyInjection;
using ReportService.Application.Abstractions;

namespace ReportService.Infrastructure.ReportBuilder;

public static class ServiceCollection
{
    public static void AddInfrastructureReportBuilder(this IServiceCollection services)
    {
        services.AddSingleton<IReportBuilder, Adptors.ReportBuilder>();
        services.AddSingleton<IReporter, Adptors.Reporter>();
    }
}