using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour{

    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Magic", "Rare", "Legendary" };

    void Start()
    {
        CreateEquipment();

        /*
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID.ToString());
        Debug.Log(newEquipment.Stamina.ToString());
        Debug.Log(newEquipment.Endurance.ToString());
        Debug.Log(newEquipment.Intelligence.ToString());
        Debug.Log(newEquipment.Strength.ToString());
        Debug.Log(newEquipment.EquipmentType.ToString());
        */
    }

    public void CreateEquipment()
    {
        newEquipment = new BaseEquipment();

        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " item";
        newEquipment.ItemDescription = "This is an equipemnt";
        newEquipment.ItemID = Random.Range(1, 101);

        newEquipment.Stamina = Random.Range(1, 11);
        newEquipment.Endurance = Random.Range(1, 11);
        newEquipment.Intelligence = Random.Range(1, 11);
        newEquipment.Strength = Random.Range(1, 11);

        ChooseEquipmentType();
    }

    private void ChooseEquipmentType()
    {
        int randomTemp = Random.Range(0, System.Enum.GetValues(typeof(BaseEquipment.EquipmentTypes)).Length);
        newEquipment.EquipmentType = (BaseEquipment.EquipmentTypes)randomTemp;
    }
}
