//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class CannonballComponentsLookup {

    public const int CannonBallBase = 0;
    public const int CannonBallCollider = 1;
    public const int CannonBallLaunch = 2;
    public const int CannonBallLaunchPower = 3;
    public const int CannonBallRigidbody = 4;
    public const int CannonBallSlowed = 5;
    public const int Transform = 6;

    public const int TotalComponents = 7;

    public static readonly string[] componentNames = {
        "CannonBallBase",
        "CannonBallCollider",
        "CannonBallLaunch",
        "CannonBallLaunchPower",
        "CannonBallRigidbody",
        "CannonBallSlowed",
        "Transform"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(CannonBall.BaseComponent),
        typeof(CannonBall.ColliderComponent),
        typeof(CannonBall.LaunchComponent),
        typeof(CannonBall.LaunchPowerComponent),
        typeof(CannonBall.RigidbodyComponent),
        typeof(CannonBall.SlowedComponent),
        typeof(TransformComponent)
    };
}
