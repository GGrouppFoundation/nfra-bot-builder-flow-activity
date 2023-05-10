using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

[JsonConverter(typeof(CamelCaseEnumConverter))]
public enum FlowTgMethod
{
    SendMessage
}