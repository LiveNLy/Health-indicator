using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthValue = 150;
    [SerializeField] private float _losedHealthByHit = 40f;
    [SerializeField] private float _healFromMed = 20f;
    [SerializeField] private float _maxHealthValue = 150;

    public event Action<float, float> SendInfo;

    private void Awake()
    {
        SendHealthInfo();
    }

    public void LoseHealth()
    {
        float damage = _losedHealthByHit;

        if (_healthValue - _losedHealthByHit < 0)
        {
            damage = _healthValue;
        }

            _healthValue -= damage;
            SendHealthInfo();
    }

    public void Heal()
    {
        float heal = _healFromMed;

        if (_maxHealthValue - _healthValue < _healFromMed)
        {
            heal = _maxHealthValue - _healthValue;
        }

        _healthValue += heal;
        SendHealthInfo();
    }

    private void SendHealthInfo()
    {
        SendInfo?.Invoke(_healthValue, _maxHealthValue);
    }
}