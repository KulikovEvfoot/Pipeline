using Leopotam.Ecs;
using Player;
using UnityEngine;

namespace Movement
{
    public class JumpSystem : IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<PlayerTag, JumpComponent, JumpEvent> _jumpFilter;
        
        public void Run()
        {
            foreach (var i in _jumpFilter)
            {
                ref var jumpComponent = ref _jumpFilter.Get2(i);

                ref var controller = ref jumpComponent.Controller;

                Debug.Log($" is ground {controller.IsGround}");
                if (controller.IsGround)
                {
                    controller.Jump(10);
                }
            }
        }
        
    }
}