using UnityEngine;
using System.Collections;

public class BasePlayer  {

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;

    private int stamina;        //health
    private int endurance;      //mana
    private int intelligence;   //magic
    private int strength;       //physical
    private int agility;        //haste
    private int resistance;     //damage reduction

    private int gold;           //money

    private int currentXP;
    private int requiredXP;
    
    public string PlayerName { get; set; }

    public int PlayerLevel { get; set; }

    public BaseCharacterClass PlayerClass { get; set; }

    public int Stamina { get; set; }

    public int Endurance { get; set; }

    public int Strength { get; set; }

    public int Intelligence { get; set; }

    public int Agility { get; set; }

    public int Resistance { get; set; }

    public int Gold { get; set; }

    public int CurrentXP { get; set; }

    public int RequiredXP { get; set; }
}