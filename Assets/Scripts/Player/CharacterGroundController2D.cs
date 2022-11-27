using System;
using UnityEditor.UIElements;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class CharacterGroundController2D : MonoBehaviour
    {
        public bool IsGround => _isGround;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.layer == _layerId)
            {
                _isGround = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.layer == _layerId)
            {
                _isGround = false;
            }
        }

        private void Awake()
        {
            _layerId = LayerMask.NameToLayer(_layerMask);
        }

        private string _layerMask = "DefaultGround";
        private int _layerId;
        private bool _isGround;
    }
}