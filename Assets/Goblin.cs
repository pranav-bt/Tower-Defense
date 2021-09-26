using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherobj = other.gameObject;
        if(otherobj.GetComponent<Defender>())
        {
            GetComponent<attacker>().attack(otherobj);
        }
    }
}
