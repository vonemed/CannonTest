using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace CannonBall
{
    [Cannonball]
    public sealed class BaseComponent : IComponent { }

    [Cannonball]
    public sealed class LaunchComponent : IComponent
    {
        public Vector2 direction;
    }

    [Cannonball]
    public sealed class RigidbodyComponent : IComponent
    {
        public Rigidbody2D value;
    }
    
    [Cannonball]
    public sealed class ColliderComponent : IComponent
    {
        [EntityIndex]
        public Collider2D value;
    }
    
    [Cannonball]
    public sealed class LaunchPowerComponent : IComponent
    {
        public float value;
    }
    
    [Cannonball]
    public sealed class SlowedComponent : IComponent
    {
        public float value;
    }
}