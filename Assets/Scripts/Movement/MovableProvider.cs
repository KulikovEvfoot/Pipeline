using System;
using UnityEngine;
using Voody.UniLeo;

namespace Movement
{
    [Serializable]
    public struct Movable
    {
        public CharacterController Controller;
        public float Speed;
    }

    public class MovableProvider : MonoProvider<Movable> {}
}