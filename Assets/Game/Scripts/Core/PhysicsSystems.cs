using Entitas;
using SlowZone;

namespace Core
{
    public class PhysicsSystems : Systems
    {
        public PhysicsSystems(Contexts contexts)
        {
            Add(new SlowZoneSystems(contexts));
        }
    }
}