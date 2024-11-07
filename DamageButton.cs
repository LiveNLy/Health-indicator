using UnityEngine;

public class DamageButton : HealthChangerButton
{
    protected override void ChangeParameter()
    {
        Health.LoseHealth();
    }
}
