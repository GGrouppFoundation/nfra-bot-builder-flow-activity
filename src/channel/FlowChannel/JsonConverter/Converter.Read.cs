using System;
using System.Text.Json;

namespace GGroupp.Infra.Bot.Builder;

partial class FlowChannelJsonConverter
{
    public override FlowChannel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType is JsonTokenType.Null)
        {
            return default;
        }

        if (reader.TokenType is not JsonTokenType.String)
        {
            throw new JsonException();
        }

        return new(reader.GetString());
    }
}