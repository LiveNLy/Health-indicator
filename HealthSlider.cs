using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSlider : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Slider _healthSlider;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _health.SendInfo += ChangeHealth;
    }

    private void OnDisable()
    {
        _health.SendInfo -= ChangeHealth;
    }

    private void ChangeHealth(float healthCount)
    {
        _healthSlider.maxValue = _healthSlider.maxValue > healthCount ? _healthSlider.maxValue : healthCount;
        _healthSlider.value = healthCount;
    }
}