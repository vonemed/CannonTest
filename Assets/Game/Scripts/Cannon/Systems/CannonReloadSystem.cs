using Entitas;
using UnityEngine;

namespace Cannon
{
    public class CannonReloadSystem : IExecuteSystem
    {
        private IGroup<CannonEntity> _cannons;

        public CannonReloadSystem(Contexts contexts)
        {
            _cannons = contexts.cannon.GetGroup(CannonMatcher.AllOf(CannonMatcher.CannonBase).NoneOf(CannonMatcher.CannonLaunch));
        }
        
        public void Execute()
        {
            foreach (var cannon in _cannons)
            {
                cannon.cannonReloadTime.value -= Time.deltaTime;

                if (cannon.cannonReloadTime.value <= 0)
                {
                    cannon.isCannonLaunch = true;
                    break;
                }
            }
        }
    }
}