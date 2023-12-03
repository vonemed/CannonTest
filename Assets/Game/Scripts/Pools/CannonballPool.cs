using System.Collections.Generic;
using CannonBall;
using UnityEngine;

namespace Pools
{
    public class CannonballPool : MonoBehaviour
    {
        private static CannonballPool _instance;
        public static CannonballPool Instance;
        
        [SerializeField] private GameObject prefab;
        [SerializeField] private int amountToPool;
        [SerializeField] private List<CannonBallView> pooledObjects = new List<CannonBallView>();

        private void Start()
        {
            if (!Instance)
            {
                Instance = this;
                _instance = Instance;
            }

            for (int i = 0; i < amountToPool; i++)
            {
                var obj = Instantiate(prefab, transform);
                var cannonBall = obj.GetComponent<CannonBallView>();
                cannonBall.Ctor(Contexts.sharedInstance);
                obj.SetActive(false);
                
                pooledObjects.Add(cannonBall);
            }
        }

        public static CannonBallView GetCannonball()
        {
            foreach (var cannonBall in _instance.pooledObjects)
            {
                if (!cannonBall.gameObject.activeSelf)
                {
                    cannonBall.gameObject.SetActive(true);
                    return cannonBall;
                }
            }

            //if no cannonBall available, spawn a new one
            var obj = Instantiate(_instance.prefab, _instance.transform);
            var cannonBallComponent = obj.GetComponent<CannonBallView>();
            cannonBallComponent.Ctor(Contexts.sharedInstance);
            _instance.pooledObjects.Add(cannonBallComponent);
            return cannonBallComponent;
        }
    }
}