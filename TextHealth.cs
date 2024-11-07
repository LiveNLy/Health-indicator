using TMPro;
using UnityEngine;

public class TextHealth : TransmittingHealthValues
{
    [SerializeField] private TextMeshProUGUI _text;

    private float _maxHealth = 100;

    protected override void ShowHealth(float healthCount)
    {
        _maxHealth = _maxHealth > healthCount ? _maxHealth : healthCount;
        _text.text = "Çהמנמגüו: " + healthCount + "/" + _maxHealth;
    }
}