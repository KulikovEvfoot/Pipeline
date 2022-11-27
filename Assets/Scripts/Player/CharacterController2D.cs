using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class CharacterController2D : MonoBehaviour
    {
        public bool IsGround => _groundController.IsGround;
        
        public void Move(float xForce)
        {
            _rigidbody.velocity = new Vector2(xForce, _rigidbody.velocity.y);
        }

        public void Jump(float force)
        {
            _rigidbody.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
        }

        private void Awake()
        {
            _bodyCollider = GetComponent<BoxCollider2D>();
            _rigidbody = GetComponent<Rigidbody2D>();
            
        }
        
        private BoxCollider2D _bodyCollider;
        private Rigidbody2D _rigidbody;
        [SerializeField] private CharacterGroundController2D _groundController;
    }
}