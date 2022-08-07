using UnityEngine;

namespace Player_container
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private PlayerAnimator _playerAnimator;
        [SerializeField] private float _moveSpeed;

        private Vector3 _moveDirection;
        private Vector2 _lastMoveDirection;
        private void Update()
        {
            float moveX = 0, moveY = 0;
        
            if (Input.GetKey(KeyCode.W)) 
                moveY = +1;
            if (Input.GetKey(KeyCode.S)) 
                moveY = -1;
            if (Input.GetKey(KeyCode.D)) 
                moveX = +1;
            if (Input.GetKey(KeyCode.A)) 
                moveX = -1;

            if ((moveX == 0 && moveY == 0) && (_moveDirection.x != 0 || _moveDirection.y != 0))
                _lastMoveDirection = _moveDirection;

            _moveDirection = new Vector3(moveX,moveY).normalized;
            _playerAnimator.PlayMove(_moveDirection,_lastMoveDirection);
        }

        private void FixedUpdate()
        {
            _rigidbody.velocity = _moveDirection * _moveSpeed;
        }
    }
}
