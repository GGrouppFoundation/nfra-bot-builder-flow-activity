using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowHeroCard
{
    private const string ContentType = "application/vnd.microsoft.card.hero";

    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; init; }

    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("images")]
    public FlatArray<FlowCardImage>? Images { get; init; }

    [JsonPropertyName("buttons")]
    public FlatArray<FlowCardAction>? Buttons { get; init; }

    [JsonPropertyName("tap")]
    public FlowCardAction? Tap { get; init; }

    public FlowAttachment ToAttachment()
        =>
        new(
            contentType: ContentType,
            content: this);

    [return: MaybeNull, NotNullIfNotNull("heroCard")]
    public static implicit operator FlowAttachment([AllowNull] FlowHeroCard heroCard)
        =>
        heroCard?.ToAttachment();
}