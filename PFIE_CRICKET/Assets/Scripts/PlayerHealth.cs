using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 20;
    public int currentHealth;

    public HealthBar healthBar;
    private int damage;

    void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))

        {
            TakeDamage(10);

        }

      


        void TakeDamage(int damage)
            {
                currentHealth -= damage;  // we simply remove our damage from the current health

                healthBar.SetHealth(currentHealth);
            }
        }


    }






/*
public class PlayerHealth : MonoBehaviour
{

    public int minimum;
    public int maxHealth; // will remain 
    private int current_health; // this will be the health that we manipulate with diffrent stats
    public int takeDamage;
    public Image mask;
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        current_health = maxHealth; // kicking off the oplayers current health will equal max health
    }

    // Update is called once per frame
    void Update()
    {
       // healthbar.value = health;
    }
    public void TakeDamage (int p_damage)
    {
        current_health -= p_damage;
        Debug.Log(current_health);

    
    }

}

*/