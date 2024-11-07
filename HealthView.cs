using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class HealthView : MonoBehaviour
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

    protected abstract void ShowHealth(float value, float maxValue);
}