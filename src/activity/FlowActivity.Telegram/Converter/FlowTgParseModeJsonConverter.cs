using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

internal sealed partial class FlowTgParseModeJsonConverter : JsonConverter<FlowTgParseMode>
{
    private const string HtmlParseModeValue = "HTML";
}