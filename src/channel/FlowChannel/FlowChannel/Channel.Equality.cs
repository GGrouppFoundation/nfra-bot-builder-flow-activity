using System;
using System.Collections.Generic;

namespace GarageGroup.Infra.Bot.Builder;

partial struct FlowChannel
{
    public bool Equals(FlowChannel other)
        =>
        Equals(this, other);

    public override bool Equals(object? obj)
        =>
        obj is FlowChannel other &&
        Equals(this, other);

    public static bool operator ==(FlowChannel left, FlowChannel right)
        =>
        Equals(left, right);

    public static bool operator !=(FlowChannel left, FlowChannel right)
        =>
        Equals(left, right) is false;

    public static bool Equals(FlowChannel left, FlowChannel right)
        =>
        IdComparer.Equals(left.Id, right.Id);

    public override int GetHashCode()
        =>
        HashCode.Combine(
            EqualityContractComparer.GetHashCode(EqualityContract), 
            IdComparer.GetHashCode(Id));

    private static EqualityComparer<Type> EqualityContractComparer
        =>
        EqualityComparer<Type>.Default;

    private static Type EqualityContract
        =>
        typeof(FlowChannel);

    private static StringComparer IdComparer
        =>
        StringComparer.InvariantCultureIgnoreCase;
}