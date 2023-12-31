//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CannonEntity {

    static readonly Cannon.FireComponent cannonFireComponent = new Cannon.FireComponent();

    public bool isCannonFire {
        get { return HasComponent(CannonComponentsLookup.CannonFire); }
        set {
            if (value != isCannonFire) {
                var index = CannonComponentsLookup.CannonFire;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : cannonFireComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<CannonEntity> _matcherCannonFire;

    public static Entitas.IMatcher<CannonEntity> CannonFire {
        get {
            if (_matcherCannonFire == null) {
                var matcher = (Entitas.Matcher<CannonEntity>)Entitas.Matcher<CannonEntity>.AllOf(CannonComponentsLookup.CannonFire);
                matcher.componentNames = CannonComponentsLookup.componentNames;
                _matcherCannonFire = matcher;
            }

            return _matcherCannonFire;
        }
    }
}
