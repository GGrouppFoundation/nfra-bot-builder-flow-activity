using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra.Bot.Builder;

partial struct FlowChannel
{
    public static FlowChannel From([AllowNull] string id = DefaultChannel)
        =>
        new(id);

    public static implicit operator FlowChannel([AllowNull] string id)
        =>
        new(id);
}