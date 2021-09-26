using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherobj = other.gameObject;
        if(otherobj.tag=="Shield")
        {
            return;
        }
        else
        { 
        if (otherobj.GetComponent<Defender>())
        {
            GetComponent<attacker>().attack(otherobj);
        }
        }
    }
}
