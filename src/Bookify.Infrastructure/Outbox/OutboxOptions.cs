namespace Bookify.Infrastructure.Outbox;

public sealed class OutboxOptions
{
    public const string Key = "Outbox";
    public int IntervalInSeconds { get; init; }

    public int BatchSize { get; init; }
}
