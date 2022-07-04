using System;
using System.Text.Json;

namespace GGroupp.Infra.Bot.Builder;

partial class FlowTgParseModeJsonConverter
{
    public override void Write(Utf8JsonWriter writer, FlowTgParseMode value, JsonSerializerOptions options)
    {
        var stringValue = GetStringValue(value);
        writer.WriteStringValue(stringValue);
    }

    private static string? GetStringValue(FlowTgParseMode parseMode)
        =>
        parseMode is FlowTgParseMode.Html ? HtmlParseModeValue : Enum.GetName(parseMode);
}