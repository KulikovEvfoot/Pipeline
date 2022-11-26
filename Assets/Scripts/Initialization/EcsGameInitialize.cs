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
        EcsSystems _update;
        EcsSystems _fixedUpdate;

        private void Start() 
        {
            _world = new EcsWorld();
            _update = new EcsSystems(_world);
            _fixedUpdate = new EcsSystems(_world);

            _update
                .Add(new PlayerInputSystem())
                .Add(new JumpSystem())
                .OneFrame<JumpComponent>()
                ;

            _fixedUpdate
                .Add(new MovementSystem())
                ;
            
            _update.ConvertScene();
            _fixedUpdate.ConvertScene();
            
            _update.Init();
            _fixedUpdate.Init();
        }


        private void Update()
        {
            _update.Run();
        }
        
        private void FixedUpdate()
        {
            _fixedUpdate.Run();
        }

        private void OnDestroy() 
        {
            _update.Destroy();
            _fixedUpdate.Destroy();
            _world.Destroy();
        }
    }
}
