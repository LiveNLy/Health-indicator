using UnityEngine;

public class DamageButton : HealthChangerButton
{
    [SerializeField] private float _damage = 40;

    protected override void ChangeParameter()
    {
        Health.LoseHealth(_damage);
    }
}
