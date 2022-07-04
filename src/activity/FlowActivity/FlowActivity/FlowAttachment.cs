using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowAttachment
{
    public FlowAttachment(string contentType, object content)
    {
        ContentType = contentType ?? string.Empty;
        Content = content;
    }

    [JsonPropertyName("contentType")]
    public string ContentType { get; }

    [JsonPropertyName("content")]
    public object Content { get; }

    [JsonPropertyName("contentUrl")]
    public string? ContentUrl { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("thumbnailUrl")]
    public string? ThumbnailUrl { get; set; }
}