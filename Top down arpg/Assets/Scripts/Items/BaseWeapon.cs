using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes
    {
        SWORD,
        AXE,
        DAGGER,
        STAFF,
        BOW,
        SHIELD
    }

    private WeaponTypes weaponType;
    private int spellEffectID;

    public WeaponTypes WeaponType { get; set; }

    public int SpellEffectID { get; set; }
}
