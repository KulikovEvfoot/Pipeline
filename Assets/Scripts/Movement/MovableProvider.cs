using System;
using Player;
using Voody.UniLeo;

namespace Movement
{
    public class MovableProvider : MonoProvider<Movable> {}

    [Serializable]
    public struct Movable
    {
        public CharacterController2D Controller;
        public float Speed;
    }
}