using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothSlider : TransmittingHealthValues
{
    private Coroutine _coroutine;

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    protected override void ShowHealth(float healthCount, float maxHealthValue)
    {
        _coroutine = StartCoroutine(SmoothHealthChanging(healthCount, maxHealthValue));
    }

    private IEnumerator SmoothHealthChanging(float healthCount, float maxHealthValue)
    {
        var wait = new WaitForSeconds(0.003f);

        _slider.maxValue = maxHealthValue;

        while (_slider.value != healthCount)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, healthCount, 0.5f);

            yield return wait;
        }
    }
}