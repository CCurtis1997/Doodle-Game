using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth2 : MonoBehaviour
{
    public Slider healthbar;
    private float _maxHealth = 100;
    private float _currentHealth;
    private float _healthUpdate;
    public float _damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentHealth == 0)
        {
            ResetHealth();
        }
    }
    public void OnCollisionEnter2D(Collision2D hit)
    {
        if(hit.gameObject.tag == "enemy")
        {
            DealDamage();
            CalculateHealth();
            healthbar.value = CalculateHealth();
        }
    }

    public void DealDamage()
    {
        _currentHealth -= _damage;
    }

    public float CalculateHealth()
    {
        return _currentHealth / _maxHealth;
    }

    private void ResetHealth()
    {
        _currentHealth = _maxHealth;
        healthbar.value = _currentHealth;
    }

}
