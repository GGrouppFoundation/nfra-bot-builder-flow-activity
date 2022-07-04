using System.Text.Json;

namespace GGroupp.Infra.Bot.Builder;

partial class FlowCardActionTypeJsonConverter
{
    public override void Write(Utf8JsonWriter writer, FlowCardActionType value, JsonSerializerOptions options)
    {
        if (string.IsNullOrEmpty(value.Type))
        {
            writer.WriteNullValue();
            return;
        }

        writer.WriteStringValue(value.Type);
    }
}