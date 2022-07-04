using System;
using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowTgInlineKeyboardMarkup : FlowTgReplyMarkup
{
    public FlowTgInlineKeyboardMarkup(FlowTgInlineKeyboardButton[][] keyboard)
        =>
        Keyboard = keyboard ?? Array.Empty<FlowTgInlineKeyboardButton[]>();

    [JsonPropertyName("inline_keyboard")]
    public FlowTgInlineKeyboardButton[][] Keyboard { get; }
}