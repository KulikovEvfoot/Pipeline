using InteractionEntity;
using Leopotam.Ecs;
using UnityEngine;

namespace Movement
{
    public class MovementSystem : IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<Body, Movable, DirectionComponent> _movementFilter;
        
        public void Run()
        {
            foreach (var i in _movementFilter)
            {
                ref var bodyComponent = ref _movementFilter.Get1(i);
                ref var movableComponent = ref _movementFilter.Get2(i);
                ref var directionComponent = ref _movementFilter.Get3(i);

                ref var transform = ref bodyComponent.Transform;
                ref var direction = ref directionComponent.Direction;
                
                ref var controller = ref movableComponent.Controller;
                ref var speed = ref movableComponent.Speed;

                var rawDirection = (transform.right * direction.x);
                
                controller.Move(rawDirection * speed * Time.deltaTime);

            }
        }
    }
}