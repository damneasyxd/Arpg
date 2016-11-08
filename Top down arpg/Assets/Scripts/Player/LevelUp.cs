using UnityEngine;
using System.Collections;

public class LevelUp {

    public int maxPlayerLevel = 100;

	public void LevelUpCharacter()
    {
        if (GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }
        if (GameInformation.PlayerLevel < maxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else{
            GameInformation.PlayerLevel = maxPlayerLevel;
        }

        DetermineRequiredXP();
    }

    private void DetermineRequiredXP()
    {
        int temp = (GameInformation.PlayerLevel * 1000) + 100;
        GameInformation.RequiredXP = temp;
    }

    private void DetermineMoneyToGive()
    {
        if(GameInformation.PlayerLevel <= 10)
        {
            //Give money while under level 10
        }

        if (GameInformation.PlayerLevel <= 20)
        {
            //Give money while under level 20
        }
    }
}
