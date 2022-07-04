using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

[JsonConverter(typeof(FlowChannelJsonConverter))]
public readonly partial struct FlowChannel : IEquatable<FlowChannel>
{
    private const string DefaultChannel = "emulator";

    static FlowChannel()
    {
        Teams = new("msteams");
        Telegram = new("telegram");
        WebChat = new("webchat");
        Emulator = new(DefaultChannel);
    }

    private readonly string? id;

    public FlowChannel([AllowNull] string id = DefaultChannel)
        =>
        this.id = string.IsNullOrEmpty(id) ? null : id;

    public string Id
        =>
        id ?? DefaultChannel;
}