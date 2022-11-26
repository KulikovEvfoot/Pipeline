using Leopotam.Ecs;
using Player;

namespace Movement
{
    public class JumpSystem : IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<PlayerTag, JumpComponent> _jumpFilter;
        
        public void Run()
        {
            foreach (var i in _jumpFilter)
            {
                
            }
        }
    }
}