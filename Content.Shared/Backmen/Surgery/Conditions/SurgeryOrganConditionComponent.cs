using Content.Shared.Body.Organ;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Medical.Surgery.Conditions;

[RegisterComponent, NetworkedComponent]
public sealed partial class SurgeryOrganConditionComponent : Component
{
    [DataField]
    [AlwaysPushInheritance]
    public ComponentRegistry? Organ;

    [DataField]
    public bool Inverse;

    [DataField]
    public bool Reattaching;
}
