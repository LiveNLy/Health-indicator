using UnityEngine;

public class HealButton : HealthChangerButton
{
    protected override void ChangeParameter()
    {
        Health.Heal();
    }
}
