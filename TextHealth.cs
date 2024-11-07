using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHealth : TransmittingHealthValues
{
    protected override void ShowHealth(float healthCount, float maxHealthValue)
    {
        _text.text = "Çהמנמגüו: " + healthCount + "/" + maxHealthValue;
    }
}