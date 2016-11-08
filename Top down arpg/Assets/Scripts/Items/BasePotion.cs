using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasePotion : BaseStatItem{

    public enum PotionTypes
    {
        HEALTH,
        MANA,
        STAMINA
    }

    private PotionTypes potionType;

    public PotionTypes PotionType { get; set; }
}
