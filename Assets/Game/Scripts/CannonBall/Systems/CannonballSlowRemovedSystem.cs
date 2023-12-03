using System.Collections.Generic;
using Entitas;

namespace CannonBall
{
    public class CannonballSlowRemovedSystem : ReactiveSystem<CannonballEntity>
    {
        public CannonballSlowRemovedSystem(IContext<CannonballEntity> context) : base(context)
        {
        }

        protected override ICollector<CannonballEntity> GetTrigger(IContext<CannonballEntity> context)
        {
            return context.CreateCollector(CannonballMatcher.CannonBallSlowed.Removed());
        }

        protected override bool Filter(CannonballEntity entity)
        {
            return true;
        }

        protected override void Execute(List<CannonballEntity> entities)
        {
            foreach (var cannonballEntity in entities)
            {
                cannonballEntity.cannonBallRigidbody.value.gravityScale = 1;
            }

        }
    }
}