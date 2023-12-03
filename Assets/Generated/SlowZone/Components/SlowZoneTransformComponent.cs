//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SlowZoneEntity {

    public TransformComponent transform { get { return (TransformComponent)GetComponent(SlowZoneComponentsLookup.Transform); } }
    public bool hasTransform { get { return HasComponent(SlowZoneComponentsLookup.Transform); } }

    public void AddTransform(UnityEngine.Transform newValue) {
        var index = SlowZoneComponentsLookup.Transform;
        var component = (TransformComponent)CreateComponent(index, typeof(TransformComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTransform(UnityEngine.Transform newValue) {
        var index = SlowZoneComponentsLookup.Transform;
        var component = (TransformComponent)CreateComponent(index, typeof(TransformComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTransform() {
        RemoveComponent(SlowZoneComponentsLookup.Transform);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SlowZoneEntity : ITransformEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class SlowZoneMatcher {

    static Entitas.IMatcher<SlowZoneEntity> _matcherTransform;

    public static Entitas.IMatcher<SlowZoneEntity> Transform {
        get {
            if (_matcherTransform == null) {
                var matcher = (Entitas.Matcher<SlowZoneEntity>)Entitas.Matcher<SlowZoneEntity>.AllOf(SlowZoneComponentsLookup.Transform);
                matcher.componentNames = SlowZoneComponentsLookup.componentNames;
                _matcherTransform = matcher;
            }

            return _matcherTransform;
        }
    }
}