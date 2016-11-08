using UnityEngine;
using System.Collections;

public static class Experience {

    private static int xpToGive;
    private static LevelUp levelUp = new LevelUp();

	public static void AddExperience()
    {
        xpToGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentXP += xpToGive;
        CheckIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    private static void CheckIfPlayerLeveled()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            levelUp.LevelUpCharacter();
        }
    }
}
