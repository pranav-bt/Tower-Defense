using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawn : MonoBehaviour
  
{
    Defender defender;
    private void OnMouseDown()
    {
        bool finalcall = defender.GetComponent<Defender>().allowed();
        if(finalcall==true)
        { 
        spawndefender(worldpos());
        }
        else
        {
            Debug.Log("You Dont Have Enough Resources");
        }
    }
    private Vector2 worldpos()
    {
        Vector2 mousepos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldposs = Camera.main.ScreenToWorldPoint(mousepos);
        return worldposs;
    }
    public Defender reutrndef(Defender getdef)
    {
        defender = getdef;
        return defender;
    }
    private void spawndefender(Vector2 position)
    {
        float x = Mathf.RoundToInt(position.x);
        float y = Mathf.RoundToInt(position.y);
        Vector2 finalpos = new Vector2(x, y);
        if(defender==null)
        {
            Debug.Log("Not Selected the Defender");
        }
        else
        { 
        Defender newdefender = Instantiate(defender, finalpos, Quaternion.identity) as Defender;
        }
    }
}
