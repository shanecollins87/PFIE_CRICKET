using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Using Player Prefs On Windows
// https://youtu.be/0pe3vu0Ayco Followed jason Weimanns video


public class Player : MonoBehaviour
{
    public PlayerData PlayerData { get; private set; } //custom static class that handles the Loading see Script for details
    

    private void OnEnable()
    {

        PlayerData = PlayerPersistence.LoadData();

        transform.position = PlayerData.Location;  // set position to location
        

    }

    private void OnDisable()
    {
        PlayerPersistence.SaveData(this); // static class to make saving and loading simple
    }

    //private void Update()
    //{

    //    //PlayerData.Eggs = 12;
    //    //UpdateEggsUI();

   
    //}

    //public void UpdateEggsUI()
    //{

    //    FindObjectOfType<Text>().text = "Total" + PlayerData.Eggs;
    
    //}
}






















    //private GameObject unitGameObject;
    //private IUnit unit;
    //private int EggAmount;

//private void Awake()

//{
//    unit = unitGameObject.GetComponent<IUnit>();

//    PlayerPrefs.DeleteAll();
//}



//// Update is called once per frame
//private void Update()


//{
//    if (Input.GetKeyDown(KeyCode.Space))  //Hit Spacebar key to save 
//    {
//        Save();

//    }

//    if (Input.GetKeyDown(KeyCode.L))  //Hit L key to load 
//    {
//        Load();

//    }

//    else
//    {
//        // No save is available
//    }

//}

//    void Save()
//    { 

//        // Save

//        Vector3 playerPosition = unit.GetPosition();
//    int eggAmount = unit.GetEggAmount();
//        PlayerPrefs.SetFloat("playerPositionX", playerPosition.x);
//        PlayerPrefs.SetFloat("playerPositionY", playerPosition.y);
//        PlayerPrefs.SetFloat("playerPositionZ", playerPosition.z);

//        PlayerPrefs.SetInt("eggAmount", eggAmount);

//        PlayerPrefs.Save();

//    Debug.Log("Saved");


//    }


//    void Load()

//    {
//        if (Input.GetKeyDown(KeyCode.L))  //Hit L key to load
//        {
//            // Load positon of player


//            {
//                float playerPositionX = PlayerPrefs.GetFloat("playerPositionX");
//                float playerPositionY = PlayerPrefs.GetFloat("playerPositionY");
//                float playerPositionZ = PlayerPrefs.GetFloat("playerPositionZ");
//                Vector3 playerPosition = new Vector3(playerPositionX, playerPositionY, playerPositionZ);
//                int eggAmount = PlayerPrefs.GetInt("eggAmount", 0); // this will load the eggAmount or default to 0 if no eggs are collected
//                Debug.Log("Loaded!");

//                unit.SetPosition(playerPosition);
//                unit.SetEggAmount(eggAmount);

//            }


//        }
//    }
//}
