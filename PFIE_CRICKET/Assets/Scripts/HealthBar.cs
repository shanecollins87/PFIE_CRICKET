using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//[ExecuteInEditMode()] // either or works
[SerializeField]
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;

    public int playerHealth = 100;
    public int damagePlayer = -25;
    public int minimum;
    public int maximum;
    public int current;
    public Image mask;   // refs the Health Bar Mask
    public Image fill;   // refs the Health Bar Fill
    public Color color;  // refs the color
    

    void Start()
    {
        print (playerHealth);
    }

   void OnCollisionEnter(Collision _collision) {

        if (_collision.gameObject.tag == "Player") 
        {
            playerHealth -= damagePlayer;
        
        }
    
    }
      

    // Update is called once per frame
    void Update()
    {
        

        GetCurrentFill();
       
       
    }

    void GetCurrentFill() // Gets fill amount , the rest calculates the fill percentage, the min and max values are set in the inspector
    {
        float currentOffset = current - minimum;
        float maximumOffset = maximum - minimum;
        float fillAmount = currentOffset / maximumOffset;
        mask.fillAmount = fillAmount;


        fill.color = color; // set fill colour to bar colour
    }


    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;   //slider starts at maximum health


    }

    public void SetHealth(int health)
    {

        slider.value = health;
    }

}
