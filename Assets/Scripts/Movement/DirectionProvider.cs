using System;
using UnityEngine;
using Voody.UniLeo;

namespace Movement
{
    [Serializable]
    public struct DirectionComponent
    {
        public Vector3 Direction;
    }

    public class DirectionProvider : MonoProvider<DirectionComponent>{}
}