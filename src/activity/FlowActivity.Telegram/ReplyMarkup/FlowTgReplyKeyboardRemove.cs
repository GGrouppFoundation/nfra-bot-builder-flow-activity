using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowTgReplyKeyboardRemove : FlowTgReplyMarkup
{
    [JsonPropertyName("remove_keyboard")]
    public bool RemoveKeyboard { get; } = true;
}