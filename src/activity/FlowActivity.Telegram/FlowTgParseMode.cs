using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

[JsonConverter(typeof(FlowTgParseModeJsonConverter))]
public enum FlowTgParseMode
{
    MarkdownV2,

    Html
}