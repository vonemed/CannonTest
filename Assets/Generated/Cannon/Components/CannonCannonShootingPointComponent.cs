//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CannonEntity {

    public Cannon.ShootingPointComponent cannonShootingPoint { get { return (Cannon.ShootingPointComponent)GetComponent(CannonComponentsLookup.CannonShootingPoint); } }
    public bool hasCannonShootingPoint { get { return HasComponent(CannonComponentsLookup.CannonShootingPoint); } }

    public void AddCannonShootingPoint(UnityEngine.Transform newValue) {
        var index = CannonComponentsLookup.CannonShootingPoint;
        var component = (Cannon.ShootingPointComponent)CreateComponent(index, typeof(Cannon.ShootingPointComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCannonShootingPoint(UnityEngine.Transform newValue) {
        var index = CannonComponentsLookup.CannonShootingPoint;
        var component = (Cannon.ShootingPointComponent)CreateComponent(index, typeof(Cannon.ShootingPointComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCannonShootingPoint() {
        RemoveComponent(CannonComponentsLookup.CannonShootingPoint);
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
public sealed partial class CannonMatcher {

    static Entitas.IMatcher<CannonEntity> _matcherCannonShootingPoint;

    public static Entitas.IMatcher<CannonEntity> CannonShootingPoint {
        get {
            if (_matcherCannonShootingPoint == null) {
                var matcher = (Entitas.Matcher<CannonEntity>)Entitas.Matcher<CannonEntity>.AllOf(CannonComponentsLookup.CannonShootingPoint);
                matcher.componentNames = CannonComponentsLookup.componentNames;
                _matcherCannonShootingPoint = matcher;
            }

            return _matcherCannonShootingPoint;
        }
    }
}
