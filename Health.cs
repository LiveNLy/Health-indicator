using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthValue = 150;
    [SerializeField] private float _maxHealthValue = 150;


    public event Action<float, float> SendInfo;

    private void Awake()
    {
        SendHealthInfo();
    }

    public void LoseHealth(float damage)
    {
        if (_healthValue > 0 && damage > 0)
        {
            _healthValue -= Mathf.Clamp(damage, 0, _healthValue);
        }

        SendHealthInfo();
    }

    public void Heal(float heal)
    {
        if (_healthValue < _maxHealthValue && heal > 0)
        {
            _healthValue += Mathf.Clamp(heal, 0, _maxHealthValue - _healthValue);
        }

        SendHealthInfo();
    }

    private void SendHealthInfo()
    {
        SendInfo?.Invoke(_healthValue, _maxHealthValue);
    }
}