using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthbar_E : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    private float health;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;   //slider starts at maximum health

        fill.color = gradient.Evaluate(1f);  // = max value at start
    }

    public void SetHealth(int health)
    {

        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);  // after damage set the correct value value throughout game play effectively changing between 0 and 1

    }

    void OnCollisionEnter(Collision _collision)
    {

        if (_collision.gameObject.tag == "Player")
        {
            slider.value -= health;

        }

    }

}
