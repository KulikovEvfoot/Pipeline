using System;
using UnityEngine;
using Voody.UniLeo;

namespace InteractionEntity
{
    public class BodyProvider : MonoProvider<Body> {}

    [Serializable]
    public struct Body
    {
        public Transform Transform;
    }
}