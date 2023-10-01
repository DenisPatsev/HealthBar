using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Slider _bar;

    private float _currentHealth;
    private float _changeStep;
    private float _startHealth;
    private float _maximalHealth;

    private void Start()
    {
        _maximalHealth = 100;
        _currentHealth = 50;
        _startHealth = _currentHealth;
        _bar.value = _currentHealth;
        _changeStep = 10;
    }

    public void TakeDamage()
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= _changeStep;
            _bar.value = Mathf.MoveTowards(_startHealth, _currentHealth, Time.time);
            _startHealth = _currentHealth;
        }
    }

    public void GetHealth()
    {
        if (_currentHealth < _maximalHealth)
        {
            _currentHealth += _changeStep;
            _bar.value = Mathf.MoveTowards(_startHealth, _currentHealth, Time.time);
            _startHealth = _currentHealth;
        }
    }
}
