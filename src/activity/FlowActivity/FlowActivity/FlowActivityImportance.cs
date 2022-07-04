using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

[JsonConverter(typeof(CamelCaseEnumConverter))]
public enum FlowActivityImportance
{
    Low,

    Normal,

    High
}