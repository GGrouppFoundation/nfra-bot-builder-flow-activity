using System.Text.Json;
using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public class CamelCaseEnumConverter : JsonStringEnumConverter
{
    public CamelCaseEnumConverter() : base(JsonNamingPolicy.CamelCase)
    {
    }
}