using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 150;
    [SerializeField] private HealthChangerButton _healButton;
    [SerializeField] private HealthChangerButton _damageButton;
    [SerializeField] private float _losedHealthByHit = 40f;
    [SerializeField] private float _healFromMed = 20f;

    public event Action<float> SendInfo;

    private void Awake()
    {
        SendHealthInfo();
    }

    private void OnEnable()
    {
        _healButton.ParameterChanging += Heal;
        _damageButton.ParameterChanging += LoseHealth;
    }

    private void FixedUpdate()
    {
        if (_health <= 0)
        {
            ResetHealth();
        }
    }

    private void OnDisable()
    {
        _healButton.ParameterChanging -= Heal;
        _damageButton.ParameterChanging -= LoseHealth;
    }

    private void ResetHealth()
    {
        _health = 150;
    }

    private void LoseHealth()
    {
        _health -= _losedHealthByHit;
        SendHealthInfo();
    }

    private void Heal()
    {
        _health += _healFromMed;
        SendHealthInfo();
    }

    private void SendHealthInfo()
    {
        SendInfo?.Invoke(_health);
    }
}