using Entitas.Unity;
using UnityEngine;

namespace CannonBall
{
    public class CannonBallView : MonoBehaviour
    {
        public CannonballEntity linkedEntity;

        public float launchPower;
        
        public void Ctor(Contexts contexts)
        {
            linkedEntity = contexts.cannonball.CreateEntity();
            gameObject.Link(linkedEntity);

            linkedEntity.isCannonBallBase = true;
            linkedEntity.AddTransform(transform);
            linkedEntity.AddCannonBallLaunchPower(launchPower);
            linkedEntity.AddCannonBallRigidbody(GetComponent<Rigidbody2D>());
            linkedEntity.AddCannonBallCollider(GetComponent<Collider2D>());
        }
    }
}