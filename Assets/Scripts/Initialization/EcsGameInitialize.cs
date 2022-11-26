using Leopotam.Ecs;
using Movement;
using Player;
using UnityEngine;
using Voody.UniLeo;

namespace Initialization
{
    public class EcsGameInitialize : MonoBehaviour
    {
        EcsWorld _world;
        EcsSystems _systems;

        private void Start() 
        {
            _world = new EcsWorld ();
            _systems = new EcsSystems(_world);

            _systems
                .Add(new PlayerInputSystem())
                .Add(new MovementSystem())
                ;
            
            _systems.ConvertScene();
            _systems.Init();
        }


        private void Update()
        {
            _systems.Run();
        }

        private void OnDestroy() 
        {
            _systems.Destroy();
            _world.Destroy();
        }
    }
}
