using Robust.Shared.Audio;
using Content.Shared.StatusIcon;
using Robust.Shared.Prototypes;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.Exodus.CentcomAgent;

/// <summary>
/// This is used for tagging a mob as a centcom agent.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class CentcomAgentComponent : Component
{

    /// <summary>
    ///
    /// </summary>
    [DataField("centcomagentStatusIcon", customTypeSerializer: typeof(PrototypeIdSerializer<FactionIconPrototype>))]
    public string CentcomAgentStatusIcon = "CentComFaction";
}
