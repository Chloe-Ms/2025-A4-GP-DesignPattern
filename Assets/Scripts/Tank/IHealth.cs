using UnityEngine;

public interface IHealth
{
    float CurrentHealth { get; set; }

    void TakeDamage(float amount);
}
