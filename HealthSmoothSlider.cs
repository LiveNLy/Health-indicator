using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothSlider : TransmittingHealthValues
{
    private Coroutine _coroutine;
    private Slider _healthSlider;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    protected override void ShowHealth(float healthCount)
    {
        _coroutine = StartCoroutine(SmoothHealthChanging(healthCount));
    }

    private IEnumerator SmoothHealthChanging(float healthCount)
    {
        var wait = new WaitForSeconds(0.003f);

        _healthSlider.maxValue = _healthSlider.maxValue > healthCount ? _healthSlider.maxValue : healthCount;

        while (_healthSlider.value != healthCount)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, healthCount, 0.5f);

            yield return wait;
        }
    }
}