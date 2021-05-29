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

<<<<<<< HEAD:PFIE_CRICKET/Assets/Scripts/HealthBar_Enemy.cs
    //public event Action<float> OnHealthPctChanged = delegate { };
=======
   //public event Action<float> OnHealthPctChanged = delegate { };
>>>>>>> d7a59646e83f1dfd1e0cab27287ffa2a9173b98a:PFIE_CRICKET/2021_HDIP-PFIE-CA1-CRICKET/Assets/Scripts/HealthBar_Enemy.cs


   






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
