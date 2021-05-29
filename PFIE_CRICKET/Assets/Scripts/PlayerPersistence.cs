using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class PlayerPersistence 
{
    public static void SaveData(Player player)
    
    {
        PlayerPrefs.SetFloat("x", player.transform.position.x); // Prefs use floats get x,y and z = Location
        PlayerPrefs.SetFloat("y", player.transform.position.y);
        PlayerPrefs.SetFloat("z", player.transform.position.z);
        PlayerPrefs.SetInt("health", 10);
        PlayerPrefs.SetInt("stars", 10);
        PlayerPrefs.SetInt("eggs", player.PlayerData.Eggs);

    }


    public static PlayerData LoadData()
    {
        float x = PlayerPrefs.GetFloat("x");
        float y = PlayerPrefs.GetFloat("y");
        float z = PlayerPrefs.GetFloat("z");
        int health = PlayerPrefs.GetInt("health");
        int stars = PlayerPrefs.GetInt("stars");
        int eggs = PlayerPrefs.GetInt("eggs");

        PlayerData playerData = new PlayerData()
        {
            Location = new Vector3(x, y, z),
            Health = health,
            Stars = stars,
            Eggs = eggs  // no comma for the last entry otherwise it wont run

        };

        return playerData;
    }

   

       
}
