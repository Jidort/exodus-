using Content.Client.Overlays;
using Content.Shared.Exodus.CentcomAgent;
using Content.Shared.StatusIcon;
using Content.Shared.StatusIcon.Components;
using Robust.Shared.Prototypes;

namespace Content.Shared.Exodus.Overlays;

public sealed class ShowCentcomAgentIconsSystem : EquipmentHudSystem<ShowCentcomAgentIconsComponent>
{
    [Dependency] private readonly IPrototypeManager _prototype = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<CentcomAgentComponent, GetStatusIconsEvent>(OnGetStatusIconsEvent);
    }

    private void OnGetStatusIconsEvent(EntityUid uid, CentcomAgentComponent component, ref GetStatusIconsEvent ev)
    {
        if (!IsActive)
            return;

        if (_prototype.TryIndex<FactionIconPrototype>(component.CentcomAgentStatusIcon, out var iconPrototype))
            ev.StatusIcons.Add(iconPrototype);
    }
}
