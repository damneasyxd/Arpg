using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

    private BaseCharacterClass mageclass1 = new BaseMageClass();
    private BaseCharacterClass warriorclass1 = new BaseWarriorClass();

    void OnGUI()
    {
        GUILayout.Label(mageclass1.CharacterClassName);
        GUILayout.Label(mageclass1.CharacterClassDescription);
        GUILayout.Label("Intelligence: " + mageclass1.Intelligence.ToString());

        GUILayout.Label(warriorclass1.CharacterClassName);
        GUILayout.Label(warriorclass1.CharacterClassDescription);
        GUILayout.Label("Strength: " + warriorclass1.Strength.ToString());
    }
}
