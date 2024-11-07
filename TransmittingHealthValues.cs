using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class TransmittingHealthValues : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected TextMeshProUGUI _text;
    protected Slider _slider;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _slider = GetComponent<Slider>();
    }

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