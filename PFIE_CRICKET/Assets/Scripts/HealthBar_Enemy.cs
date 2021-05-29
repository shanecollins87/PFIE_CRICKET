using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //allows use of Image

public class HealthBar_Enemy : MonoBehaviour
{
    public Image HealthBar;
    public float CurrentHealth;
    private float maxHealth = 20;
    Enemy Player;

    //public event Action<float> OnHealthPctChanged = delegate { };


   






    private void Start()
    {

        //Find
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<Enemy>();
    
    }

    private void Update()
    {
        CurrentHealth = Player.Health;
        HealthBar.fillAmount = CurrentHealth / maxHealth;
        
    }

    private void OnTriggerEnter(Collider collison
        )
    {

        
        {

            Destroy(gameObject);
        }


        
    }
}
