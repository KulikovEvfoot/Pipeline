using System;
using UnityEngine;
using Voody.UniLeo;

namespace InteractionEntity
{
    [Serializable]
    public struct Body
    {
        public Transform Transform;
    }
    
    public class BodyProvider : MonoProvider<Body> {}
    
}