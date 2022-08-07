using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class DestructibleObstacles : MonoBehaviour, IHealth
    {
        [SerializeField] protected int _health;
        
        public event Action HealthDied;
        public event Action<int> HealthChanged;

        public int Current
        {
            get => _health;
            set => _health = value;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0)
                _health = 0;
            HealthChanged?.Invoke(_health);

            Debug.Log("Take damage");
            if (IsDie())
            {
                _health = 0;
                HealthDied?.Invoke();
            }
        }

        private bool IsDie() => 
            _health <= 0;
    }
}