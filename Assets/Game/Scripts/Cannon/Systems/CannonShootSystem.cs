using System.Collections.Generic;
using Entitas;
using Pools;

namespace Cannon
{
    public class CannonShootSystem : ReactiveSystem<CannonEntity>
    {
        public CannonShootSystem(IContext<CannonEntity> context) : base(context)
        {
        }

        protected override ICollector<CannonEntity> GetTrigger(IContext<CannonEntity> context)
        {
            return context.CreateCollector(CannonMatcher.CannonLaunch.Added());
        }

        protected override bool Filter(CannonEntity entity)
        {
            return true;
        }

        protected override void Execute(List<CannonEntity> entities)
        {
            foreach (var cannonEntity in entities)
            {
                cannonEntity.isCannonFire = true;
                
                var cannonBall = CannonballPool.GetCannonball();
                cannonBall.transform.position = cannonEntity.cannonShootingPoint.value.position;
                cannonBall.linkedEntity.AddCannonBallLaunch(cannonEntity.cannonShootingPoint.value.right);
            }
        }
    }
}