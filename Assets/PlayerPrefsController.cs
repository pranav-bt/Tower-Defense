using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour{
    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string FIRSTTIME_KEY = "first time";
    const float minvalue = 0f;
    const float maxvalue = 1f;
    public static void SetMasterVolume(float volume)
    {
        if(volume >= minvalue && volume <= maxvalue )
        { 
        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Error");
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    public static void SetDifficulty(float difficulty)
    {
        if(difficulty>=minvalue&&difficulty<=maxvalue)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Error");
        }
    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
    public static int GetFirst()
    {
        return PlayerPrefs.GetInt(FIRSTTIME_KEY);
    }
    public static void SetFirst(int done)
    {
        PlayerPrefs.SetInt(FIRSTTIME_KEY,done);
    }

}
