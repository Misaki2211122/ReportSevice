using System.Text;
using ReportService.Application.Abstractions;

namespace ReportService.Infrastructure.ReportBuilder.Adptors;

public class ReportBuilder : IReportBuilder
{
    private readonly Random _rnd = new Random();


    public ReportBuilder()
    {
        _rnd = new Random();
    }
    
    public async Task<byte[]> Build()
    {
        //Получить случайное число (в диапазоне от 5 до 45)
        int sleepTime = _rnd.Next(0, 45);
        
        byte[] _bytes = Encoding.ASCII.GetBytes($"Report built in [{sleepTime}] s.");
        
        if (_rnd.Next(0, 9) < 2)
            throw new Exception("Report failed");

        await SleepIndefinitely(sleepTime);

        return _bytes;
    }
    
    private async Task SleepIndefinitely(int sleepTime)
    {
        for (int i = 0; i < sleepTime; i++)
        {
            Thread.Sleep(1000);
        }
    }
    
}