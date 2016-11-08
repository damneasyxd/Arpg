using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour{

    private BasePotion newPotion;
    private string[] itemNames = new string[3] { "Health", "Mana", "Stamina"};

    void Start()
    {
        CreatePotion();

        /*
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID.ToString());
        Debug.Log(newPotion.PotionType.ToString());  
        */      
    }

    public void CreatePotion()
    {
        newPotion = new BasePotion();

        newPotion.ItemName = itemNames[Random.Range(0, 2)] + " potion";
        newPotion.ItemDescription = "This is a potion";
        newPotion.ItemID = Random.Range(1, 101);

        ChoosePotionType();
    }

    private void ChoosePotionType()
    {
        int randomTemp = Random.Range(0, System.Enum.GetValues(typeof(BasePotion.PotionTypes)).Length);
        newPotion.PotionType = (BasePotion.PotionTypes)randomTemp;
    }
}
