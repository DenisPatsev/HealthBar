using UnityEngine;
using UnityEngine.UI;

public class BarDrawer : MonoBehaviour
{
    [SerializeField] private Slider _bar;
    [SerializeField] private Player _player;

    private void Start()
    {
        _bar.value = _player.CurrentHealth;
    }

    public void ChangeBarValue()
    {
        _bar.value = Mathf.MoveTowards(_player.StartHealth, _player.CurrentHealth, Time.time);
    }
}
