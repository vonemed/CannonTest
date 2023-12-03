using Cannon;
using CannonBall;
using Entitas;
using SlowZone;

namespace Core
{
    public sealed class GameSystems : Systems
    {
        public GameSystems(Contexts contexts)
        {
            Add(new CannonSystems(contexts));
            Add(new CannonBallSystems(contexts));

            //Event
            Add(new CannonEventSystems(contexts));
            
            //Cleanup
            Add(new CannonCleanupSystems(contexts));
        }

        public override void Initialize()
        {
            base.Initialize();
            
            // here we initialize all UNIQUE and STATIC props, classes, entities etc.
        }
    }
}