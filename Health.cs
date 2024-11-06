using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 150;
    [SerializeField] private HealButton _healButton;
    [SerializeField] private DamageButton _damageButton;
    [SerializeField] private float _losedHealthByHit = 40f;
    [SerializeField] private float _healFromMed = 20f;

    public event Action<float> SendInfo;

    private void Awake()
    {
        SendHealthInfo();
    }

    private void OnEnable()
    {
        _healButton.HealPressed += Heal;
        _damageButton.DamageGiven += LoseHealth;
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
        _healButton.HealPressed -= Heal;
        _damageButton.DamageGiven -= LoseHealth;
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

    private void Death()
    {
        _health = 0;
    }

    private void SendHealthInfo()
    {
        SendInfo?.Invoke(_health);
    }
}