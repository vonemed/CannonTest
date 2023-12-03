
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Cannon
{
    [Cannon]
    public sealed class BaseComponent : IComponent {}
    
    [Cannon]
    public sealed class LaunchComponent : IComponent { }

    [Cannon]
    public sealed class ReloadTimeComponent : IComponent
    {
        public float value;
    }
    
    [Cannon]
    public sealed class ShootingPointComponent : IComponent
    {
        public Transform value;
    }
    
    [Cannon, Event(EventTarget.Self), Cleanup(CleanupMode.RemoveComponent)]
    public sealed class FireComponent : IComponent { }
}