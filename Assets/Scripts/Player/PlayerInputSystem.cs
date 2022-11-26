using Leopotam.Ecs;
using Movement;
using UnityEngine;

namespace Player
{
    public class PlayerInputSystem : IEcsInitSystem, IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<PlayerTag, DirectionComponent> _direction;

        private float _moveX;
        
        public void Init()
        {
            _moveX = Input.GetAxisRaw("Horizontal");
        }
        
        public void Run()
        {
            foreach (var i in _direction)
            {
                ref var direction = ref _direction.Get2(i).Direction;

                direction.x = _moveX;
            }
        }
    }
}