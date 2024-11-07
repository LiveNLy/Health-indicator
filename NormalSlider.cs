using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class NormalSlider : TransmittingHealthValues
{
    protected override void ShowHealth(float healthCount, float maxHealthValue)
    {
        _slider.maxValue = maxHealthValue;
        _slider.value = healthCount;
    }
}