using Entitas;
using UnityEngine;

namespace SlowZone
{
    [SlowZone]
    public sealed class BaseComponent : IComponent { }

    //Manual remove
    [SlowZone]
    public sealed class CollisionWithComponent : IComponent
    {
        public Collider2D value;
    }
    
    //Manual remove
    [SlowZone]
    public sealed class CollisionExitWithComponent : IComponent
    {
        public Collider2D value;
    }

    [SlowZone]
    public sealed class RadiusComponent : IComponent
    {
        public float value;
    }

    [SlowZone]
    public sealed class SlowPowerComponent : IComponent
    {
        public float value;
    }
}