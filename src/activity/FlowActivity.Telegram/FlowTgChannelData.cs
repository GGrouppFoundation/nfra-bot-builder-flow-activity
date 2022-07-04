using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowTgChannelData
{
    public FlowTgChannelData(FlowTgParameters parameters)
        =>
        Parameters = parameters ?? new();

    [JsonPropertyName("method")]
    public FlowTgMethod Method { get; init; }

    [JsonPropertyName("parameters")]
    public FlowTgParameters Parameters { get; }

    public static FlowActivity ToActivity(string recipientId)
        =>
        new(FlowChannel.Telegram, recipientId);
}