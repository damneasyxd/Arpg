using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	void Start () {
        LoadInformation.LoadAllInformation();
        Debug.Log("Player Name: " + GameInformation.PlayerName);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Stamina: " + GameInformation.Stamina);
        Debug.Log("Player Endurance: " + GameInformation.Endurance);
        Debug.Log("Player Intelligence: " + GameInformation.Intelligence);
        Debug.Log("Player Strength: " + GameInformation.Strength);
        Debug.Log("Player Agility: " + GameInformation.Agility);
        Debug.Log("Player Resistance: " + GameInformation.Resistance);
        Debug.Log("Player Gold: " + GameInformation.Gold);
    }

}
