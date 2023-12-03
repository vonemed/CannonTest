using System.Collections.Generic;
using System.Linq;
using Entitas;

namespace SlowZone
{
    public class SlowZoneCollisionExitSystem : ReactiveSystem<SlowZoneEntity>
    {
        public SlowZoneCollisionExitSystem(IContext<SlowZoneEntity> context) : base(context)
        {
        }

        protected override ICollector<SlowZoneEntity> GetTrigger(IContext<SlowZoneEntity> context)
        {
            return context.CreateCollector(SlowZoneMatcher.SlowZoneCollisionExitWith.Added());
        }

        protected override bool Filter(SlowZoneEntity entity)
        {
            return true;
        }

        protected override void Execute(List<SlowZoneEntity> entities)
        {
            foreach (var slowZoneEntity in entities)
            {
                
                var attachedRigidbody = slowZoneEntity.slowZoneCollisionExitWith.value.attachedRigidbody;
                attachedRigidbody.gravityScale = 1;
                
                slowZoneEntity.RemoveSlowZoneCollisionExitWith();
            }
        }
    }
}