using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health;
    public Slider healthbar;
    public float Health = 20f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Takedamage();
        }

    }

    public void Takedamage()
    {
        health -= 5;
    }

    private void Update()
        
    {
        healthbar.value = health;
        Debug.Log(health);
    
    }

}