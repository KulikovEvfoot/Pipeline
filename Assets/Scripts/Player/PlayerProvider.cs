using System;
using Leopotam.Ecs;
using Voody.UniLeo;

namespace Player
{
    public class PlayerProvider : MonoProvider<PlayerTag>{}

    [Serializable]
    public struct PlayerTag : IEcsIgnoreInFilter{}
}