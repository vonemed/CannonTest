using System.Collections.Generic;
using Entitas;

namespace CannonBall
{
    public class CannonballSlowedSystem : ReactiveSystem<CannonballEntity>
    {
        public CannonballSlowedSystem(IContext<CannonballEntity> context) : base(context)
        {
        }

        protected override ICollector<CannonballEntity> GetTrigger(IContext<CannonballEntity> context)
        {
            return context.CreateCollector(CannonballMatcher.CannonBallSlowed.Added());
        }

        protected override bool Filter(CannonballEntity entity)
        {
            return true;
        }

        protected override void Execute(List<CannonballEntity> entities)
        {
            foreach (var cannonballEntity in entities)
            {
                var attachedRigidbody = cannonballEntity.cannonBallRigidbody.value;
                attachedRigidbody.gravityScale /= cannonballEntity.cannonBallSlowed.value;
                attachedRigidbody.velocity /= cannonballEntity.cannonBallSlowed.value;
            }
        }
    }
}