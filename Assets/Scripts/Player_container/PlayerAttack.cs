using UnityEngine;

namespace Player_container
{
    public class PlayerAttack
    {
        private readonly int _damage;
        private readonly bool _isUseFul;
        public PlayerAttack(int damage)
        {
            _damage = damage;
        }
        public void Attack(Collider2D collider2d)
        {
            
        }
    }
}