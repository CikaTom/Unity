using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
/***************************************************
* Class responsible for some Player Preferences
*
* 
* *********************************************/

public class PlayerPrefsManager : MonoBehaviour {


    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";
    // level_unlocked_2 and so on...

    public static void setMasterVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("PlayerPrefsManager<SetMasterVolume> the min value is 0 and the max value = 1 curent set on: " + volume +
                            "look at sending class !!!");
        }
    }

    public static float getMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    // set dificolty of level
    //
    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= 1f && difficulty <= 3f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("PlayerPrefsManager<SetDifficulty> the min value is 0 and the max is 1 curent set on: " + difficulty + "look at sending class!!!");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }


    public static void SetLevelUnloked(int levelUnlockd)
    {
        Debug.Log("scenemanager.senecoint value: " + (SceneManager.sceneCountInBuildSettings - 1));
        if (levelUnlockd >= 1 && levelUnlockd <= SceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + levelUnlockd.ToString(), 1);// set the unlocked level to 1 (this makes a list of levels unloced (1=true)
        }
        else
        {
            Debug.LogError("PlayerPrefsManager<SetLevelUnloked>try to unlock a level wat is not in the build order the level number was:" + levelUnlockd +
                            "look at sending class!!! or build order");
        }
    }

    // get the level wat was unlocked
    public static bool unlockLevel(int level)
    {
        Debug.Log("scenemanager.senecoint value: " + (SceneManager.sceneCountInBuildSettings - 1));
        if (level >= 1 && level <= (SceneManager.sceneCountInBuildSettings) - 1)
        {
            // gets the level in to a temp slot
            int temp = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());// Gets the unlocked (this gets a list of levels unloced (1=true) (0=false)
            if (temp == 1)
            {
                // treu return  true
                return true;
            }
        }// end if it is a useble level
        // otherway it must been false return false
        return false;
    }// end

}
