using System;
using Voody.UniLeo;

namespace Player
{
    [Serializable]
    public struct PlayerTag {}
    
    public class PlayerProvider : MonoProvider<PlayerTag> {}

}