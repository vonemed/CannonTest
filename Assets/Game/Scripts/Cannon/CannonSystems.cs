
namespace Cannon
{
    public sealed class CannonSystems : Feature
    {
        public CannonSystems(Contexts contexts)
        {
            Add(new CannonReloadSystem(contexts)); //todo: replace with contexts.cannon
            Add(new CannonShootSystem(contexts.cannon));
        }
    }
}