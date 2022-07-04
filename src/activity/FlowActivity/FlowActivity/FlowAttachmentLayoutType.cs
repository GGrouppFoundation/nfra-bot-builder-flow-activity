using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

[JsonConverter(typeof(CamelCaseEnumConverter))]
public enum FlowAttachmentLayoutType
{
    List,

    Carousel
}