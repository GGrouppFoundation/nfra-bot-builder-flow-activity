using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class FlowActivity
{
    public FlowActivity(FlowChannel channel, FlowChannelAccount recipient)
    {
        Channel = channel;
        Recipient = recipient;
    }

    public FlowActivity(FlowChannel channel, string recipientId)
    {
        Channel = channel;
        Recipient = new(recipientId);
    }

    [JsonPropertyName("channelId")]
    public FlowChannel Channel { get; }

    [JsonPropertyName("recipient")]
    public FlowChannelAccount Recipient { get; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("textFormat")]
    public FlowTextFormatType? TextFormat { get; init; }

    [JsonPropertyName("from")]
    public FlowChannelAccount? From { get; init; }

    [JsonPropertyName("inputHint")]
    public FlowInputHint InputHint { get; init; }

    [JsonPropertyName("deliveryMode")]
    public FlowDeliveryMode? DeliveryMode { get; init; }

    [JsonPropertyName("importance")]
    public FlowActivityImportance? Importance { get; init; }

    [JsonPropertyName("expiration")]
    public DateTimeOffset? Expiration { get; init; }

    [JsonPropertyName("code")]
    public FlowEndOfConversationCode? Code { get; init; }

    [JsonPropertyName("localTimezone")]
    public string? LocalTimezone { get; init; }

    [JsonPropertyName("value")]
    public object? Value { get; init; }

    [JsonPropertyName("label")]
    public string? Label { get; init; }

    [JsonPropertyName("replyToId")]
    public string? ReplyToId { get; init; }

    [JsonPropertyName("channelData")]
    public object? ChannelData { get; init; }

    [JsonPropertyName("type")]
    public FlowActivityType Type { get; init; }

    [JsonPropertyName("attachmentLayout")]
    public FlowAttachmentLayoutType? AttachmentLayout { get; init; }

    [JsonPropertyName("attachments")]
    public FlatArray<FlowAttachment>? Attachments { get; init; }
}