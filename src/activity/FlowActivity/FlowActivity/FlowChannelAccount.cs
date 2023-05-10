using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class FlowChannelAccount
{
    public FlowChannelAccount(string id)
        =>
        Id = id ?? string.Empty;

    [JsonPropertyName("id")]
    public string Id { get; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("aadObjectId")]
    public string? AadObjectId { get; init; }

    [JsonPropertyName("role")]
    public string? Role { get; init; }
}