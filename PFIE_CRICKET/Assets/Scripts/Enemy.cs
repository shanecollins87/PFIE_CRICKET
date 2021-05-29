
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public int health;
    public Slider healthbar_E;
    public int damage;

    public int Enemyhealth;
    public Slider healthbar;

    
    public int Health = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Takedamage();
            Takehit();
        }

    }

    public void Takedamage()
    {
        Enemyhealth -= 10;
    }


    public void Takehit()
    {
        Health -= 10;
    }



    private void Update ()
        
    {
        
        //healthbar.value = health;

        Debug.Log(health);

        Debug.Log(Enemyhealth);

    }

}