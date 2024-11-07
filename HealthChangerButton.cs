using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthChangerButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    public event Action ParameterChanging;

    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeParameter);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeParameter);
    }

    private void ChangeParameter()
    {
        ParameterChanging.Invoke();
    }
}
