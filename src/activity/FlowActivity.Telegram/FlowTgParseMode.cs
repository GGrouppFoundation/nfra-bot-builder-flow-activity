using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

[JsonConverter(typeof(FlowTgParseModeJsonConverter))]
public enum FlowTgParseMode
{
    MarkdownV2,

    Html
}