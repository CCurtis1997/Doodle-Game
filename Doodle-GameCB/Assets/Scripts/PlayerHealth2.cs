using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth2 : MonoBehaviour
{
    public Slider healthbar;
    private float _maxHealth = 100;
    private float _currentHealth;
    private float _healthUpdate;
    public float _damage = 5;
    public float deathLevel;

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
            //ResetHealth();
            SceneManager.LoadScene("Grassland");
        }

        if (transform.position.y <= deathLevel)
        {
            _currentHealth = 0;
        }

    }
    public void OnCollisionEnter2D(Collision2D hit)
    {
        if(hit.gameObject.tag == "Enemy")
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
