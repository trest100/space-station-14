using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Backmen.Surgery.Steps;

[RegisterComponent, NetworkedComponent]
[Prototype("SurgerySteps")]
public sealed partial class SurgeryStepComponent : Component
{

    [DataField]
    [AlwaysPushInheritance] // organs
    public ComponentRegistry? Tool;

    [DataField]
    public ComponentRegistry? Add;

    [DataField]
    public ComponentRegistry? BodyAdd;

    [DataField]
    public ComponentRegistry? Remove;

    [DataField]
    public ComponentRegistry? BodyRemove;

    [DataField]
    public float Duration = 2f;
}
