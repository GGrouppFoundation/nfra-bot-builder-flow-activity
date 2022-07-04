using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowMessage<T> where T : notnull
{
    public FlowMessage(FlowChannel channel, string fromId, [AllowNull] string temporaryActivityId, [DisallowNull] T value)
    {
        Channel = channel;
        FromId = fromId ?? string.Empty;
        TemporaryActivityId = string.IsNullOrEmpty(temporaryActivityId) ? null : temporaryActivityId;
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    [JsonPropertyName("channel")]
    public FlowChannel Channel { get; }

    [JsonPropertyName("fromId")]
    public string FromId { get; }

    [JsonPropertyName("temporaryActivityId")]
    public string? TemporaryActivityId { get; }

    [JsonPropertyName("message")]
    public T Value { get; }
}