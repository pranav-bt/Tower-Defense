using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider VolSlider;
    [SerializeField] Slider DiffSlider;
    [SerializeField] float defaultvolume = 0.8f;
    [SerializeField] float defaultdiff = 0.5f;
    void Start()
    {
        VolSlider.value = PlayerPrefsController.GetMasterVolume();
        DiffSlider.value = PlayerPrefsController.GetDifficulty();
    }
    private void Update()
    {
        var MusicPlayer = FindObjectOfType<MusicPlayer>();
        if(MusicPlayer)
        {
            MusicPlayer.setvolume(VolSlider.value);
        }
        else { }
    }
    public void saveandexit()
    {
        PlayerPrefsController.SetMasterVolume(VolSlider.value);
        PlayerPrefsController.SetDifficulty(DiffSlider.value);
        FindObjectOfType<Loadscene>().mainmenu();
    }
    public void defaults()
    {
        VolSlider.value = defaultvolume;
        DiffSlider.value = defaultdiff;
    }

      
}
