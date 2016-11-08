using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass{

	public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A strong and powerful hero that uses weapons.";
        Stamina = 10;
        Endurance = 15;
        Strength = 15;
        Intelligence = 10;
        Agility = 15;
        Resistance = 10;
    }
}
