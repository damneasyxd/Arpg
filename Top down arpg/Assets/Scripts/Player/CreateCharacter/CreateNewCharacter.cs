using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;

    private bool isMageClass;
    private bool isWarriorClass;
    private string playerName = "Entername";

    void Start()
    {
        newPlayer = new BasePlayer();
    }

	void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 15);

        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");

        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }

            CreateNewPlayer();
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();
        }

        if (GUILayout.Button("Load"))
        {
            SceneManager.LoadScene("Test");
        }
    }

    void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Stamina = newPlayer.Stamina;
        GameInformation.Endurance = newPlayer.Endurance;
        GameInformation.Intelligence = newPlayer.Intelligence;
        GameInformation.Strength = newPlayer.Strength;
        GameInformation.Agility = newPlayer.Agility;
        GameInformation.Resistance = newPlayer.Resistance;
        GameInformation.Gold = newPlayer.Gold;
    }

    void CreateNewPlayer()
    {
        newPlayer.PlayerName = playerName;
        newPlayer.PlayerLevel = 1;

        newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
        newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
        newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
        newPlayer.Strength = newPlayer.PlayerClass.Strength;
        newPlayer.Agility = newPlayer.PlayerClass.Agility;
        newPlayer.Resistance = newPlayer.PlayerClass.Resistance;
        newPlayer.Gold = 10;
        /*
        Debug.Log("Player Name: " + newPlayer.PlayerName);
        Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + newPlayer.PlayerLevel);
        Debug.Log("Player Stamina: " + newPlayer.Stamina);
        Debug.Log("Player Endurance: " + newPlayer.Endurance);
        Debug.Log("Player Intelligence: " + newPlayer.Intelligence);
        Debug.Log("Player Strength: " + newPlayer.Strength);
        Debug.Log("Player Agility: " + newPlayer.Agility);
        Debug.Log("Player Resistance: " + newPlayer.Resistance);
        Debug.Log("Player Gold: " + newPlayer.Gold);*/
    }
}
