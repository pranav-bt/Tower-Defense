using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] GameObject pos;
    int counter = 0;
    public void coingen()
    {
        if(counter==4)
        { 
        Vector3 finalpos = new Vector3(pos.transform.position.x, pos.transform.position.y);
        GameObject coinn = Instantiate(coin, finalpos, Quaternion.identity) as GameObject;
        counter = 0;
        }
        else
        {
            counter++;
        }
    }
}
