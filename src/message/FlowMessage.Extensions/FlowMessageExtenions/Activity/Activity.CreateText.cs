using System;

namespace GGroupp.Infra.Bot.Builder;

partial class FlowMessageExtenions
{
    public static FlowActivity CreateTextActivity<T>(this FlowMessage<T> message, string text)
        where T : notnull
    {
        ArgumentNullException.ThrowIfNull(message);

        return new(channel: message.Channel, recipientId: message.FromId)
        {
            Id = message.TemporaryActivityId,
            Text = text ?? string.Empty
        };
    }
}