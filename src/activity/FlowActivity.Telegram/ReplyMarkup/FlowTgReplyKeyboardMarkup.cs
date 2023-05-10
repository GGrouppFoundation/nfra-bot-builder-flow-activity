using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class FlowTgReplyKeyboardMarkup : FlowTgReplyMarkup
{
    public FlowTgReplyKeyboardMarkup(FlowTgKeyboardButton[][] keyboard)
        =>
        Keyboard = keyboard ?? Array.Empty<FlowTgKeyboardButton[]>();

    [JsonPropertyName("keyboard")]
    public FlowTgKeyboardButton[][] Keyboard { get; }

    [JsonPropertyName("resize_keyboard")]
    public bool? ResizeKeyboard { get; init; }

    [JsonPropertyName("one_time_keyboard")]
    public bool? OneTimeKeyboard { get; init; }

    [JsonPropertyName("input_field_placeholder")]
    public string? InputFieldPlaceholder { get; init; }
}