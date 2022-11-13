using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

namespace Initialization
{
    public class EcsGameInitialize : MonoBehaviour
    {
        EcsWorld _world;
        EcsSystems _systems;

        private void Start () 
        {
            _world = new EcsWorld ();
            _systems = new EcsSystems(_world);

            _systems.ConvertScene();

            AddInjection();
            AddSystems();
            AddOneFrames();
            
            _systems.Init ();
        }

        private void AddInjection()
        {
            
        }
        
        private void AddSystems()
        {
            
        }

        private void AddOneFrames()
        {
            
        }

        private void Update ()
        {
            _systems.Run ();
        }

        private void OnDestroy () 
        {
            _systems.Destroy ();
            _world.Destroy ();
        }
    }
}
