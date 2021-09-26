using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audiosource;
    void Start()
    {
        DontDestroyOnLoad(this);
        audiosource = GetComponent<AudioSource>();
        audiosource.volume = PlayerPrefsController.GetMasterVolume();
    }

    public void setvolume(float volume)
    {
        audiosource.volume = volume;
    }
}
