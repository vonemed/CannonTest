
using Entitas;
using UnityEngine;

[Cannon, Cannonball, SlowZone]
public sealed class TransformComponent : IComponent
{
    public Transform value;
}
