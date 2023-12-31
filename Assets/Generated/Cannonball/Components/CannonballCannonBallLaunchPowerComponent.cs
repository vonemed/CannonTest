//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CannonballEntity {

    public CannonBall.LaunchPowerComponent cannonBallLaunchPower { get { return (CannonBall.LaunchPowerComponent)GetComponent(CannonballComponentsLookup.CannonBallLaunchPower); } }
    public bool hasCannonBallLaunchPower { get { return HasComponent(CannonballComponentsLookup.CannonBallLaunchPower); } }

    public void AddCannonBallLaunchPower(float newValue) {
        var index = CannonballComponentsLookup.CannonBallLaunchPower;
        var component = (CannonBall.LaunchPowerComponent)CreateComponent(index, typeof(CannonBall.LaunchPowerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCannonBallLaunchPower(float newValue) {
        var index = CannonballComponentsLookup.CannonBallLaunchPower;
        var component = (CannonBall.LaunchPowerComponent)CreateComponent(index, typeof(CannonBall.LaunchPowerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCannonBallLaunchPower() {
        RemoveComponent(CannonballComponentsLookup.CannonBallLaunchPower);
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
public sealed partial class CannonballMatcher {

    static Entitas.IMatcher<CannonballEntity> _matcherCannonBallLaunchPower;

    public static Entitas.IMatcher<CannonballEntity> CannonBallLaunchPower {
        get {
            if (_matcherCannonBallLaunchPower == null) {
                var matcher = (Entitas.Matcher<CannonballEntity>)Entitas.Matcher<CannonballEntity>.AllOf(CannonballComponentsLookup.CannonBallLaunchPower);
                matcher.componentNames = CannonballComponentsLookup.componentNames;
                _matcherCannonBallLaunchPower = matcher;
            }

            return _matcherCannonBallLaunchPower;
        }
    }
}
