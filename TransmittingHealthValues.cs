using UnityEngine;

public abstract class TransmittingHealthValues : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.SendInfo += ShowHealth;
    }

    private void OnDisable()
    {
        _health.SendInfo -= ShowHealth;
    }

    protected abstract void ShowHealth(float value);
}