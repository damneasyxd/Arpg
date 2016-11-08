using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseItem {

    private int itemID;
    private string itemName;
    private string itemDescription;

    public enum ItemTypes {
        EQUIPMENT,
        WEAPON,
        POTION,
        CHEST
    }

    private ItemTypes itemType;

    public string ItemName { get; set; }

    public string ItemDescription { get; set; }

    public int ItemID { get; set; }

    public ItemTypes ItemType { get; set; }
}
