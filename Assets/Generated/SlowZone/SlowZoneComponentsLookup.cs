//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class SlowZoneComponentsLookup {

    public const int SlowZoneBase = 0;
    public const int SlowZoneCollisionExitWith = 1;
    public const int SlowZoneCollisionWith = 2;
    public const int SlowZoneRadius = 3;
    public const int SlowZoneSlowPower = 4;
    public const int Transform = 5;

    public const int TotalComponents = 6;

    public static readonly string[] componentNames = {
        "SlowZoneBase",
        "SlowZoneCollisionExitWith",
        "SlowZoneCollisionWith",
        "SlowZoneRadius",
        "SlowZoneSlowPower",
        "Transform"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(SlowZone.BaseComponent),
        typeof(SlowZone.CollisionExitWithComponent),
        typeof(SlowZone.CollisionWithComponent),
        typeof(SlowZone.RadiusComponent),
        typeof(SlowZone.SlowPowerComponent),
        typeof(TransformComponent)
    };
}
