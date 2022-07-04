using System;
using System.Collections.Generic;

namespace GGroupp.Infra.Bot.Builder;

partial struct FlowCardActionType
{
    public bool Equals(FlowCardActionType other)
        =>
        Equals(this, other);

    public override bool Equals(object? obj)
        =>
        obj is FlowCardActionType other &&
        Equals(this, other);

    public static bool operator ==(FlowCardActionType left, FlowCardActionType right)
        =>
        Equals(left, right);

    public static bool operator !=(FlowCardActionType left, FlowCardActionType right)
        =>
        Equals(left, right) is false;

    public static bool Equals(FlowCardActionType left, FlowCardActionType right)
        =>
        TypeComparer.Equals(left.Type, right.Type);

    public override int GetHashCode()
        =>
        HashCode.Combine(
            EqualityContractComparer.GetHashCode(EqualityContract), 
            TypeComparer.GetHashCode(Type));

    private static EqualityComparer<Type> EqualityContractComparer
        =>
        EqualityComparer<Type>.Default;

    private static Type EqualityContract
        =>
        typeof(FlowCardActionType);

    private static StringComparer TypeComparer
        =>
        StringComparer.InvariantCultureIgnoreCase;
}