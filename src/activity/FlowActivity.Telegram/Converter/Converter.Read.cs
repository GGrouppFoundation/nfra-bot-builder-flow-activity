using System;
using System.Text.Json;

namespace GGroupp.Infra.Bot.Builder;

partial class FlowTgParseModeJsonConverter
{
    public override FlowTgParseMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType is JsonTokenType.Null)
        {
            return default;
        }

        if (reader.TokenType is not JsonTokenType.String)
        {
            throw new JsonException();
        }

        var value = reader.GetString();

        if (string.IsNullOrEmpty(value))
        {
            return default;
        }

        if (string.Equals(value, HtmlParseModeValue, StringComparison.InvariantCulture))
        {
            return FlowTgParseMode.Html;
        }

        return Enum.Parse<FlowTgParseMode>(value);
    }
}