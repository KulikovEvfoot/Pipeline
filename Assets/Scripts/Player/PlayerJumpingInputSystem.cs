using Leopotam.Ecs;
using Movement;
using UnityEngine;

namespace Player
{
    public class PlayerJumpingInputSystem : IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<PlayerTag, JumpComponent> _jump;
        
        public void Run()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var i in _jump)
                {
                    ref var entity = ref _jump.GetEntity(i);
                    entity.Get<JumpEvent>();
                }
            }
        }
    }
}