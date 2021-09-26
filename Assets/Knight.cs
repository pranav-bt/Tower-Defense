using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherobj = other.gameObject;
        if (otherobj.GetComponent<Defender>())
        {
            GetComponent<attacker>().attack(otherobj);
        }
    }

    public void cast()
    {
        Defender[] defender = FindObjectsOfType<Defender>();
        int numofdef = defender.Length;
        if(numofdef==0)
        {
            return;
        }
        else
        { 
        for(int i=0; i<numofdef; i++)
        {
            int num = Random.Range(0, 10);
            if(num<=2)
            {
                GameObject newexplosion = Instantiate(explosion, defender[i].transform.position, Quaternion.identity) as GameObject;
                Destroy(defender[i].gameObject);
                Destroy(newexplosion, 1f);
                    return;
            }
        }
        }
    }
}
