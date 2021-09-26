using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject wincanvas;
    [SerializeField] GameObject losecanvas;
    int attackercount = 0;
    bool timeoverr=false;
    private void Start()
    {
        wincanvas.SetActive(false);
        losecanvas.SetActive(false);
    }

    public void attackercountplus(int num)
    {
        attackercount += num;
        
    }

    public void attackercountminus(int num)
    {
        attackercount -= num;
        if (attackercount == 0 && timeoverr == true)
        {
            StartCoroutine("HandleWin");
        }
    }

    public void timeover()
    {
       
            
            timeoverr = true;
            Attackerspawn[] spawns = FindObjectsOfType<Attackerspawn>();
            foreach(Attackerspawn attacker in spawns)
            {
            attacker.setspawnfalse();

            }
        
    }

    IEnumerator HandleWin()
    {
        wincanvas.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(5);
        FindObjectOfType<Loadscene>().mainmenu();
    }

    public void HandleLoss()
    {
        losecanvas.SetActive(true);
        GetComponent<AudioSource>().Play();
        Time.timeScale = 0;
    }

}
