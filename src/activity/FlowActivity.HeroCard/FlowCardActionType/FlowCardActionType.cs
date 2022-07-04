using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

[JsonConverter(typeof(FlowCardActionTypeJsonConverter))]
public readonly partial struct FlowCardActionType : IEquatable<FlowCardActionType>
{
    static FlowCardActionType()
    {
        OpenUrl = new("openUrl");
        ImBack = new("imBack");
        PostBack = new("postBack");
        PlayAudio = new("playAudio");
        PlayVideo = new("playVideo");
        ShowImage = new("showImage");
        DownloadFile = new("downloadFile");
        Signin = new("signin");
        Call = new("call");
        MessageBack = new("messageBack");
    }

    private readonly string? type;

    public FlowCardActionType([AllowNull] string type)
        =>
        this.type = string.IsNullOrEmpty(type) ? null : type;

    public string Type => type ?? string.Empty;
}