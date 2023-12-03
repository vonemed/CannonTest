using System.Linq;
using Entitas.Unity;
using UnityEngine;

namespace SlowZone
{
    public class SlowZoneView : MonoBehaviour
    {
        [SerializeField] private float slowPower;
        [SerializeField] private float radius;

        public SlowZoneEntity linkedEntity;

        private void Start()
        {
            linkedEntity = Contexts.sharedInstance.slowZone.CreateEntity();
            gameObject.Link(linkedEntity);

            linkedEntity.isSlowZoneBase = true;
            
            linkedEntity.AddTransform(transform);
            linkedEntity.AddSlowZoneSlowPower(slowPower);
            linkedEntity.AddSlowZoneRadius(radius);
        }

        //Collisions
        private void OnTriggerEnter2D(Collider2D col)
        {
            //todo: move to system
            Contexts.sharedInstance.cannonball.
                GetEntitiesWithCannonBallCollider(col).
                FirstOrDefault()?.AddCannonBallSlowed(slowPower);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            //todo: move to system
            Contexts.sharedInstance.cannonball.
                GetEntitiesWithCannonBallCollider(other).
                FirstOrDefault()?.RemoveCannonBallSlowed();
        }

        //Debug
        private void OnDrawGizmos() => Gizmos.DrawWireSphere(transform.position, radius);
    }
}