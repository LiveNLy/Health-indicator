using TMPro;
using UnityEngine;

public class TextHealth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Health _health;

    private float _maxHealth = 100;

    private void OnEnable()
    {
        _health.SendInfo += ShowHealth;
    }

    private void OnDisable()
    {
        _health.SendInfo -= ShowHealth;
    }

    private void ShowHealth(float healthCount)
    {
        _maxHealth = _maxHealth > healthCount ? _maxHealth : healthCount;
        _text.text = "Çהמנמגüו: " + healthCount + "/" + _maxHealth;
    }
}