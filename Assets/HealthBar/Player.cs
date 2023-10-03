using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _healthChange;
    [SerializeField] private float _currentHealth;

    private float _startHealth;
    private float _changeStep;
    private float _maximalHealth;

    public float CurrentHealth => _currentHealth;
    public float StartHealth => _startHealth;

    private void Start()
    {
        _maximalHealth = 100;
        _startHealth = _currentHealth;
        _changeStep = 10;
    }

    public void TakeDamage()
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= _changeStep;
            _healthChange.Invoke();
            _startHealth = _currentHealth;
        }
    }

    public void GetTreated()
    {
        if (_currentHealth < _maximalHealth)
        {
            _currentHealth += _changeStep;
            _healthChange.Invoke();
            _startHealth = _currentHealth;
        }
    }
}
