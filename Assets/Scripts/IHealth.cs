using System;

namespace DefaultNamespace
{
    public interface IHealth
    {
        event Action HealthDied;
        event Action<int> HealthChanged;
        int Current { get; set; }
        void TakeDamage(int damage);
    }
}