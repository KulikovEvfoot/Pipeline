using Leopotam.Ecs;
using Movement;
using UnityEngine;

namespace Player
{
    public class PlayerMovingInputSystem : IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<PlayerTag, DirectionComponent> _direction;

        private float _moveX;
        
        public void Run()
        {
            _moveX = Input.GetAxisRaw("Horizontal");
            
            foreach (var i in _direction)
            {
                ref var direction = ref _direction.Get2(i).Direction;
                direction.x = _moveX;
            }
        }
    }
}