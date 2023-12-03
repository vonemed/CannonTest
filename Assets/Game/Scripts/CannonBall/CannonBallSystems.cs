namespace CannonBall
{
    public class CannonBallSystems : Feature
    {
        public CannonBallSystems(Contexts contexts)
        {
            Add(new CannonballLaunchSystem(contexts.cannonball));
            Add(new CannonballSlowedSystem(contexts.cannonball));
            Add(new CannonballSlowRemovedSystem(contexts.cannonball));
        }
    }
}