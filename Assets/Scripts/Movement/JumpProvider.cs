using System;
using Leopotam.Ecs;
using Player;
using Voody.UniLeo;

namespace Movement
{
    public class JumpProvider : MonoProvider<JumpComponent>{}

    [Serializable]
    public struct JumpComponent
    {
        public CharacterController2D Controller;
    }
    
    public struct JumpEvent : IEcsIgnoreInFilter{}
    
}