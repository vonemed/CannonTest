using System;
using Entitas;
using UnityEngine;

namespace Core
{
    [DisallowMultipleComponent]
    public sealed class GameCore : MonoBehaviour
    {
        private GameSystems _gameSystems;
        private PhysicsSystems _physicsSystems;

        private void Awake()
        {
            _gameSystems = new GameSystems(Contexts.sharedInstance);
            _physicsSystems = new PhysicsSystems(Contexts.sharedInstance);
        }
        
        private void Start()
        {
            _gameSystems.Initialize();
        }

        private void Update()
        {
            _gameSystems.Execute();
        }

        private void FixedUpdate()
        {
            _physicsSystems.Execute();
        }

        private void LateUpdate()
        {
            _gameSystems.Cleanup();
        }
    }
}