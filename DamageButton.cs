using System;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Button _damageButton;

    public event Action DamageGiven;

    private void OnEnable()
    {
        _damageButton.onClick.AddListener(Damage);
    }

    private void OnDisable()
    {
        _damageButton.onClick.RemoveListener(Damage);
    }

    private void Damage()
    {
        DamageGiven.Invoke();
    }
}