using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass{

    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "A wizard that uses powerful magic.";
        Stamina = 10;
        Endurance = 15;
        Strength = 10;
        Intelligence = 20;
        Agility = 10;
        Resistance = 10;
    }
}
