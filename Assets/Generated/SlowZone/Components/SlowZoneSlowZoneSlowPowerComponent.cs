//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SlowZoneEntity {

    public SlowZone.SlowPowerComponent slowZoneSlowPower { get { return (SlowZone.SlowPowerComponent)GetComponent(SlowZoneComponentsLookup.SlowZoneSlowPower); } }
    public bool hasSlowZoneSlowPower { get { return HasComponent(SlowZoneComponentsLookup.SlowZoneSlowPower); } }

    public void AddSlowZoneSlowPower(float newValue) {
        var index = SlowZoneComponentsLookup.SlowZoneSlowPower;
        var component = (SlowZone.SlowPowerComponent)CreateComponent(index, typeof(SlowZone.SlowPowerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSlowZoneSlowPower(float newValue) {
        var index = SlowZoneComponentsLookup.SlowZoneSlowPower;
        var component = (SlowZone.SlowPowerComponent)CreateComponent(index, typeof(SlowZone.SlowPowerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSlowZoneSlowPower() {
        RemoveComponent(SlowZoneComponentsLookup.SlowZoneSlowPower);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class SlowZoneMatcher {

    static Entitas.IMatcher<SlowZoneEntity> _matcherSlowZoneSlowPower;

    public static Entitas.IMatcher<SlowZoneEntity> SlowZoneSlowPower {
        get {
            if (_matcherSlowZoneSlowPower == null) {
                var matcher = (Entitas.Matcher<SlowZoneEntity>)Entitas.Matcher<SlowZoneEntity>.AllOf(SlowZoneComponentsLookup.SlowZoneSlowPower);
                matcher.componentNames = SlowZoneComponentsLookup.componentNames;
                _matcherSlowZoneSlowPower = matcher;
            }

            return _matcherSlowZoneSlowPower;
        }
    }
}
