using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelTime : MonoBehaviour
{
    float leveltime;
    bool levelfin=false;
    
    // Update is called once per frame
    public void Awake()
    {
        float diffval = PlayerPrefsController.GetDifficulty();
        if (diffval >= 0 && diffval <= 0.2)
        {
            leveltime = 30f;
        }
        else if (diffval > 0.2 && diffval <= 0.4)
        {
            leveltime = 45f;
        }
        else if (diffval > 0.4 && diffval <= 0.6)
        {
            leveltime = 50f;
        }
        else if (diffval > 0.6 && diffval <= 0.8)
        {
            leveltime = 70f;
        }
        else if (diffval > 0.8 && diffval <= 1)
        {
            leveltime = 90f;
        }
    }


        void Update()
    {
        if (levelfin) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / leveltime;
        bool timer = Time.timeSinceLevelLoad >= leveltime;
        if (timer )
        {
            FindObjectOfType<LevelController>().timeover();
            levelfin = true;
        }
    }
}
