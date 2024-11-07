using UnityEngine;

public class HealButton : HealthChangerButton
{
    [SerializeField] private float _heal = 20;

    protected override void ChangeParameter()
    {
        Health.Heal(_heal);
    }
}
