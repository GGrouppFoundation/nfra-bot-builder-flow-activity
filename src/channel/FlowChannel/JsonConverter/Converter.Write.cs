using System.Text.Json;

namespace GGroupp.Infra.Bot.Builder;

partial class FlowChannelJsonConverter
{
    public override void Write(Utf8JsonWriter writer, FlowChannel value, JsonSerializerOptions options)
    {
        if (string.IsNullOrEmpty(value.Id))
        {
            writer.WriteNullValue();
            return;
        }

        writer.WriteStringValue(value.Id);
    }
}