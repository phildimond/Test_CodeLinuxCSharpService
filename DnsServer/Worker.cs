namespace DnsServer;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("My Test Service running at: {time}", DateTimeOffset.Now);
            _logger.LogWarning("A warning from My Test Service at: {time}", DateTimeOffset.Now);
            _logger.LogError("An error from My Test Service at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
        _logger.LogInformation("My Test Service received a cancellation token at: {time}", DateTimeOffset.Now);
    }
}
