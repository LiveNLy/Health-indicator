using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSlider : TransmittingHealthValues
{
    private Slider _healthSlider;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    protected override void ShowHealth(float healthCount)
    {
        _healthSlider.maxValue = _healthSlider.maxValue > healthCount ? _healthSlider.maxValue : healthCount;
        _healthSlider.value = healthCount;
    }
}