using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

[JsonConverter(typeof(CamelCaseEnumConverter))]
public enum FlowEndOfConversationCode
{
    Unknown,

    CompletedSuccessfully,

    UserCancelled,

    BotTimedOut,

    BotIssuedInvalidMessage,

    ChannelFailed
}