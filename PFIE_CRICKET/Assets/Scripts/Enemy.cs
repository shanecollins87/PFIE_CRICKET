
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int Enemyhealth;
    public Slider healthbar;
    
    public int Health = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Takedamage();
        }

    }

    public void Takedamage()
    {
        Enemyhealth -= 10;
    }

    private void Update ()
        
    {
        
        //healthbar.value = health;
        Debug.Log(Enemyhealth);
    
    }

}