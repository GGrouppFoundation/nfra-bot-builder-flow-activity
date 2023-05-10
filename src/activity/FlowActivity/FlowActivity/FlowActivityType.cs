using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

[JsonConverter(typeof(CamelCaseEnumConverter))]
public enum FlowActivityType
{
    Message,

    ContactRelationUpdate,

    Typing,

    Trace,

    Suggestion,

    MessageUpdate,

    MessageReaction,

    MessageDelete,

    Invoke,

    InstallationUpdate,

    Handoff,

    DeleteUserData,

    Delay,

    Event,

    EndOfConversation,

    ConversationUpdate,

    Command,

    CommandResult
}