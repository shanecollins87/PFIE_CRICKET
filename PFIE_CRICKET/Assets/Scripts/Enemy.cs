
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
<<<<<<< HEAD:PFIE_CRICKET/Assets/Scripts/Enemy.cs
    public int health;
    public Slider healthbar_E;
    public int damage;
=======
    public int Enemyhealth;
    public Slider healthbar;
>>>>>>> d7a59646e83f1dfd1e0cab27287ffa2a9173b98a:PFIE_CRICKET/2021_HDIP-PFIE-CA1-CRICKET/Assets/Scripts/Enemy.cs
    
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

<<<<<<< HEAD:PFIE_CRICKET/Assets/Scripts/Enemy.cs
    public void Takehit()
    {
        Health -= 10;
    }

=======
>>>>>>> d7a59646e83f1dfd1e0cab27287ffa2a9173b98a:PFIE_CRICKET/2021_HDIP-PFIE-CA1-CRICKET/Assets/Scripts/Enemy.cs
    private void Update ()
        
    {
        
        //healthbar.value = health;
<<<<<<< HEAD:PFIE_CRICKET/Assets/Scripts/Enemy.cs
        Debug.Log(health);
=======
        Debug.Log(Enemyhealth);
>>>>>>> d7a59646e83f1dfd1e0cab27287ffa2a9173b98a:PFIE_CRICKET/2021_HDIP-PFIE-CA1-CRICKET/Assets/Scripts/Enemy.cs
    
    }

}