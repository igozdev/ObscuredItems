using UnityEngine;
using UnityEngine.UI;
using ouint = ObscuredItems.ObscuredUInt;

public class PlayerHealth : MonoBehaviour
{
    private ouint _damage;
    private ouint _health;
    private Text _healthText;

    private void Start()
    {
        _health = new ouint(100);
        _damage = new ouint(10);
        _healthText = GameObject.Find("HealthText").GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            DamagePlayer(_damage);

        _healthText.text = _health.ToString();
    }

    private void DamagePlayer(ouint damage)
    {
        _health -= _damage;
    }
}
