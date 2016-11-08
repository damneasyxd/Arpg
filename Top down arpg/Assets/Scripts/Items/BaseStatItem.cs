using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseStatItem : BaseItem {

    private int stamina;
    private int endurance;
    private int strength;
    private int intelligence;

    public int Stamina { get; set; }

    public int Endurance { get; set; }

    public int Strength { get; set; }

    public int Intelligence { get; set; }
}
