using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;
    private string[] itemNames = new string[4] { "Common", "Magic", "Rare", "Legendary" };

    void Start()
    {
        CreateWeapon();

        /*
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.Stamina.ToString());
        Debug.Log(newWeapon.Endurance.ToString());
        Debug.Log(newWeapon.Intelligence.ToString());
        Debug.Log(newWeapon.Strength.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        */
    }

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();

        newWeapon.ItemName = itemNames[Random.Range(0, 3)] + " item";
        newWeapon.ItemDescription = "This is a weapon";
        newWeapon.ItemID = Random.Range(1, 101);
        
        newWeapon.Stamina = Random.Range(1, 11);
        newWeapon.Endurance = Random.Range(1, 11);
        newWeapon.Intelligence = Random.Range(1, 11);
        newWeapon.Strength = Random.Range(1, 11);

        ChooseWeaponType();
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(0, System.Enum.GetValues(typeof(BaseWeapon.WeaponTypes)).Length);
        newWeapon.WeaponType = (BaseWeapon.WeaponTypes)randomTemp;
    }
}
