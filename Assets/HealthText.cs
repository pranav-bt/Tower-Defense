using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    // Start is called before the first frame update
    int health;
    Text healthtext;
    public void Awake()
    {
        float diffval = PlayerPrefsController.GetDifficulty();
        if (diffval >= 0 && diffval <= 0.1)
        {
            health = 100;
        }
        else if (diffval > 0.1 && diffval <= 0.2)
        {
            health = 95;
        }
        else if (diffval > 0.2 && diffval <= 0.3)
        {
            health = 90;
        }
        else if (diffval > 0.3 && diffval <= 0.4)
        {
            health = 85;
        }
        else if (diffval > 0.4 && diffval <= 0.5)
        {
            health = 80;
        }
        else if (diffval > 0.5 && diffval <= 0.6)
        {
            health = 75;
        }
        else if (diffval > 0.6 && diffval <= 0.7)
        {
            health = 70;
        }
        else if (diffval > 0.7 && diffval <= 0.8)
        {
            health = 65;
        }
        else if (diffval > 0.8 && diffval <= 0.9)
        {
            health = 60;
        }
        else if (diffval > 0.9 && diffval <= 1)
        {
            health = 50;
        }
    }
        private void Start()
    {
        healthtext = GetComponent<Text>();
        updatedisplay();
    }
    private void updatedisplay()
    {
        healthtext.text = health.ToString();
    }
   
    public void subhealth(int amt)
    {
        health -= amt;
        healthtext.text = health.ToString();
        if(health<=0)
        {
            FindObjectOfType<LevelController>().HandleLoss();
        }
    }

}
