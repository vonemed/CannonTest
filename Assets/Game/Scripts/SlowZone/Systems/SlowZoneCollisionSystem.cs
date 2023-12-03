using System.Collections.Generic;
using System.Linq;
using Entitas;

namespace SlowZone
{
    public class SlowZoneCollisionSystem : ReactiveSystem<SlowZoneEntity>
    {
        public SlowZoneCollisionSystem(IContext<SlowZoneEntity> context) : base(context)
        {
        }

        protected override ICollector<SlowZoneEntity> GetTrigger(IContext<SlowZoneEntity> context)
        {
            return context.CreateCollector(SlowZoneMatcher.SlowZoneCollisionWith.Added());
        }

        protected override bool Filter(SlowZoneEntity entity)
        {
            return true;
        }

        protected override void Execute(List<SlowZoneEntity> entities)
        {
            foreach (var slowZoneEntity in entities)
            {


                
                slowZoneEntity.RemoveSlowZoneCollisionWith();
            }
        }
    }
}