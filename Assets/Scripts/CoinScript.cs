    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    int coins;
    Text cointext;
    public void Awake()
    {
        float diffval = PlayerPrefsController.GetDifficulty();
        if (diffval >= 0 && diffval <= 0.1)
        {
            coins = 400;
        }
        else if (diffval > 0.1 && diffval <= 0.2)
        {
            coins = 390;
        }
        else if (diffval > 0.2 && diffval <= 0.3)
        {
            coins = 380;
        }
        else if (diffval > 0.3 && diffval <= 0.4)
        {
            coins = 370;
        }
        else if (diffval > 0.4 && diffval <= 0.5)
        {
            coins = 360;
        }
        else if (diffval > 0.5 && diffval <= 0.6)
        {
            coins = 350;
        }
        else if (diffval > 0.6 && diffval <= 0.7)
        {
            coins = 340;
        }
        else if (diffval > 0.7 && diffval <= 0.8)
        {
            coins = 330;
        }
        else if (diffval > 0.8 && diffval <= 0.9)
        {
            coins = 320;
        }
        else if (diffval > 0.9 && diffval <= 1)
        {
            coins = 300;
        }
    }
        private void Start()
    {
        cointext = GetComponent<Text>();
        updatedisplay();
    }
    private void updatedisplay()
    {
        cointext.text = coins.ToString();
    }
    public void addcoins(int amt)
    {
        coins += amt;
        updatedisplay();
    }
    public bool subcoins(int amt)
    {
        if(coins>=amt)
        {
            coins -= amt;
            updatedisplay();
            return true;
        }
        else
        {
            Debug.Log("Not enough resources");
            return false;
        }
    }
}
