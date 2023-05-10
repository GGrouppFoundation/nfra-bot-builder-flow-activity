namespace GarageGroup.Infra.Bot.Builder;

partial struct FlowChannel
{
    public override string ToString()
        =>
        Id;

    public static implicit operator string(FlowChannel source)
        =>
        source.Id;
}