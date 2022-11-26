using System;
using Player;
using Voody.UniLeo;

namespace Movement
{
    [Serializable]
    public struct Movable
    {
        public CharacterController2D Controller;
        public float Speed;
    }

    public class MovableProvider : MonoProvider<Movable> {}
}