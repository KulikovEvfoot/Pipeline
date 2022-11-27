using System;
using UnityEngine;
using Voody.UniLeo;

namespace Movement
{
    public class DirectionProvider : MonoProvider<DirectionComponent>{}

    [Serializable]
    public struct DirectionComponent
    {
        public Vector3 Direction;
    }
}