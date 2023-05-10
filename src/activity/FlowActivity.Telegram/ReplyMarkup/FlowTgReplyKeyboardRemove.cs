using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class FlowTgReplyKeyboardRemove : FlowTgReplyMarkup
{
    [JsonPropertyName("remove_keyboard")]
    public bool RemoveKeyboard { get; } = true;
}