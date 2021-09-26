using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int cost;
    bool canspawn;
    public bool allowed()
    {
        CoinScript subtracter = FindObjectOfType<CoinScript>();
        canspawn = subtracter.subcoins(cost);
        if(canspawn==true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
