using UnityEngine;

namespace Player_container
{
    [RequireComponent(typeof(Animator))]
    public class PlayerAnimator : MonoBehaviour
    {
        private readonly int MoveXHash = Animator.StringToHash("AnimMoveX");
        private readonly int MoveYHash = Animator.StringToHash("AnimMoveY");
        private readonly int MoveMagnitude = Animator.StringToHash("AnimMoveMagnitude");
        private readonly int LastMoveX = Animator.StringToHash("AnimLastMoveX");
        private readonly int LastMoveY = Animator.StringToHash("AnimLastMoveY");
        
        [SerializeField] private Animator _animator;
        
        public void PlayMove(Vector3 moveDirection, Vector2 lastMoveDirection)
        {
            _animator.SetFloat(MoveXHash,moveDirection.x);
            _animator.SetFloat(MoveYHash, moveDirection.y);
            _animator.SetFloat(MoveMagnitude,moveDirection.magnitude);
            _animator.SetFloat(LastMoveX,lastMoveDirection.x);
            _animator.SetFloat(LastMoveY,lastMoveDirection.y);
        }
    }
}