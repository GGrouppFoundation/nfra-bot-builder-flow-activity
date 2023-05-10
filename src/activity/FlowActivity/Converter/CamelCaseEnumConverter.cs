using System.Text.Json;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

public class CamelCaseEnumConverter : JsonStringEnumConverter
{
    public CamelCaseEnumConverter() : base(JsonNamingPolicy.CamelCase)
    {
    }
}