using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEquipment : BaseStatItem { 

    public enum EquipmentTypes
    {
        HELM,
        BODY,
        LEGS,
        GLOVES,
        BOOTS,
        AMULET,
        RING
    }

    private EquipmentTypes equipmentType;
    private int enchantEffectID;

    public EquipmentTypes EquipmentType { get; set; }

    public int EnchantEffectID { get; set; }
}
