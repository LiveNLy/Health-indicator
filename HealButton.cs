using System;
using UnityEngine;
using UnityEngine.UI;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Button _healButton;

    public event Action HealPressed;

    private void OnEnable()
    {
        _healButton.onClick.AddListener(Heal);
    }

    private void OnDisable()
    {
        _healButton.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        HealPressed.Invoke();
    }
}
