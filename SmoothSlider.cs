using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothSlider : NormalSlider
{
    private Coroutine _coroutine;

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    protected override void ShowHealth(float healthCount, float maxHealthValue)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(SmoothHealthChanging(healthCount, maxHealthValue));
    }

    private IEnumerator SmoothHealthChanging(float healthCount, float maxHealthValue)
    {
        var wait = new WaitForEndOfFrame();

        _slider.maxValue = maxHealthValue;

        while (_slider.value != healthCount)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, healthCount, 0.3f);

            yield return wait;
        }
    }
}