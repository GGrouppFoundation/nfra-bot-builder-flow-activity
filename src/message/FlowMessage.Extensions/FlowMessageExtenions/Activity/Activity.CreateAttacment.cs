using System;

namespace GGroupp.Infra.Bot.Builder;

partial class FlowMessageExtenions
{
    public static FlowActivity CreateAttachmentActivity<T>(this FlowMessage<T> message, FlowAttachment attachment)
        where T : notnull
    {
        ArgumentNullException.ThrowIfNull(message);
        ArgumentNullException.ThrowIfNull(attachment);

        return new(channel: message.Channel, recipientId: message.FromId)
        {
            Id = message.TemporaryActivityId,
            AttachmentLayout = FlowAttachmentLayoutType.List,
            Attachments = new[] { attachment }
        };
    }
}