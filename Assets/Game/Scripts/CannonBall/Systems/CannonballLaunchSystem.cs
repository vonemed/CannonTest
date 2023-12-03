using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace CannonBall
{
    public class CannonballLaunchSystem : ReactiveSystem<CannonballEntity>
    {
        public CannonballLaunchSystem(IContext<CannonballEntity> context) : base(context)
        {
        }

        protected override ICollector<CannonballEntity> GetTrigger(IContext<CannonballEntity> context)
        {
            return context.CreateCollector(CannonballMatcher.CannonBallLaunch.Added());
        }

        protected override bool Filter(CannonballEntity entity)
        {
            return true;
        }

        protected override void Execute(List<CannonballEntity> entities)
        {
            foreach (var cannonballEntity in entities)
            {
                cannonballEntity.cannonBallRigidbody.value.AddForce(
                    cannonballEntity.cannonBallLaunch.direction * cannonballEntity.cannonBallLaunchPower.value);
            }
        }
    }
}