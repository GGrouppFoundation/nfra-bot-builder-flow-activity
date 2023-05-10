using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

internal sealed partial class FlowTgParseModeJsonConverter : JsonConverter<FlowTgParseMode>
{
    private const string HtmlParseModeValue = "HTML";
}