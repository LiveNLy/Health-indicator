using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHealth : HealthView
{
    protected TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    protected override void ShowHealth(float healthCount, float maxHealthValue)
    {
        _text.text = "Çהמנמגüו: " + healthCount + "/" + maxHealthValue;
    }
}