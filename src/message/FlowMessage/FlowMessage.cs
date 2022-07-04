using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowMessage<T> where T : notnull
{
    public FlowMessage(FlowChannel channel, string fromId, [AllowNull] string temporaryActivityId, [DisallowNull] T message)
    {
        Channel = channel;
        FromId = fromId ?? string.Empty;
        TemporaryActivityId = string.IsNullOrEmpty(temporaryActivityId) ? null : temporaryActivityId;
        Message = message ?? throw new ArgumentNullException(nameof(message));
    }

    [JsonPropertyName("channel")]
    public FlowChannel Channel { get; }

    [JsonPropertyName("fromId")]
    public string FromId { get; }

    [JsonPropertyName("temporaryActivityId")]
    public string? TemporaryActivityId { get; }

    [JsonPropertyName("message")]
    public T Message { get; }
}